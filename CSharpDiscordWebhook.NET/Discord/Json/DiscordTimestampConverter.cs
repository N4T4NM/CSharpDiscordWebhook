using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpDiscordWebhook.NET.Discord.Json
{
    public class DiscordTimestampConverter : JsonConverter<DiscordTimestamp>
    {
        public override DiscordTimestamp Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string str = reader.GetString();
            if (str == null) return null;
            return new(str);
        }
        public override void Write(Utf8JsonWriter writer, DiscordTimestamp value, JsonSerializerOptions options)
            => writer.WriteStringValue(value.ToString());
    }
}
