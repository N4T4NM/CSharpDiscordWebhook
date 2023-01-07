using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpDiscordWebhook.NET.Discord.Json
{
    public sealed class DiscordColorConverter : JsonConverter<DiscordColor>
    {
        public override DiscordColor Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            => new(reader.GetInt32());
        public override void Write(Utf8JsonWriter writer, DiscordColor value, JsonSerializerOptions options)
            => writer.WriteNumberValue(value.ToHexRgb());
    }
}
