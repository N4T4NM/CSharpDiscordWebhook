using System;
using System.IO;
using System.Net;
using System.Text.Json;

namespace CSharpDiscordWebhook.NET.Discord
{
    public class DiscordWebhook
    {
        /// <summary>
        /// Webhook url
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Send webhook message
        /// </summary>
        public void Send(DiscordMessage message, FileInfo file = null)
        {
            if (string.IsNullOrEmpty(Url))
                throw new ArgumentNullException("Invalid Webhook URL.");

            string bound = "------------------------" + DateTime.Now.Ticks.ToString("x");

            WebClient webhook = new WebClient();
            webhook.Headers.Add("Content-Type", "multipart/form-data; boundary=" + bound);

            MemoryStream stream = new MemoryStream();
            stream.Write($"--{bound}\r\n");

            if (file != null && file.Exists)
            {
                string fileBegin = $"Content-Disposition: form-data; name=\"file\"; filename=\"{file.Name}\"\r\n";
                string fileContentType = "Content-Type: application/octet-stream\r\n\r\n";
                string fileEnd = $"\r\n--{bound}\r\n";

                stream.Write(fileBegin);
                stream.Write(fileContentType);
                stream.Write(File.ReadAllBytes(file.FullName));
                stream.Write(fileEnd);
            }

            string jsonBegin = "Content-Disposition: form-data; name=\"payload_json\"\r\n";
            string jsonContentType = "Content-Type: application/json\r\n\r\n";
            string jsonBody = JsonSerializer.Serialize<DiscordMessage>(message);
            string jsonEnd = $"\r\n--{bound}--";

            stream.Write(jsonBegin);
            stream.Write(jsonContentType);
            stream.Write(jsonBody);
            stream.Write(jsonEnd);

            try
            {
                webhook.UploadData(Url, stream.ToArray());
            } catch(WebException ex)
            {
                throw new InvalidOperationException(ex.Response.GetResponseStream().Decode());
            }
            stream.Dispose();
        }
    }
}
