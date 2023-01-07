using System;
using System.Text.Json;

namespace CSharpDiscordWebhook.NET.Discord.Json
{
    public sealed class DiscordJsonNaming : JsonNamingPolicy
    {
        public override string ConvertName(string name)
        {
            string result = string.Empty;
            for (int i = 0; i < name.Length; i++)
            {
                char c = name[i];
                if (char.IsUpper(c) && i > 0)
                    result += '_';

                result += char.ToLower(c);
            }

            return result;
        }
    }
}
