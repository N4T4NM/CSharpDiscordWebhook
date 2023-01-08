using CSharpDiscordWebhook.NET.Discord.Json;
using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace CSharpDiscordWebhook.NET.Discord;

public class DiscordWebhook
{
    /// <summary>
    /// Webhook url
    /// </summary>
    public Uri Uri { get; set; }

    /// <summary>
    /// Send webhook message
    /// </summary>
    public async Task SendAsync(DiscordMessage message, params FileInfo[] files)
    {
        using HttpClient httpClient = new HttpClient();

        string bound = "------------------------" + DateTime.Now.Ticks.ToString("x");

        MultipartFormDataContent httpContent = new MultipartFormDataContent(bound);

        foreach (var file in files)
        {
            ByteArrayContent fileContent = new ByteArrayContent(await File.ReadAllBytesAsync(file.FullName));
            fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/octet-stream");
            httpContent.Add(fileContent, file.Name, file.Name);
        }

        StringContent jsonContent = new StringContent(JsonSerializer.Serialize(message, JSON_SETTINGS));
        jsonContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
        httpContent.Add(jsonContent, "payload_json");

        HttpResponseMessage response = await httpClient.PostAsync(Uri, httpContent);
        if (!response.IsSuccessStatusCode)
            throw new Exception(await response.Content.ReadAsStringAsync());
    }

    private static readonly JsonSerializerOptions JSON_SETTINGS = new()
    {
        PropertyNamingPolicy = new DiscordJsonNaming(),
        IgnoreReadOnlyProperties = false,
        DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters =
        {
            new DiscordColorConverter(),
            new DiscordTimestampConverter(),
            new AllowedMentionTypeConverter()
        }
    };
}