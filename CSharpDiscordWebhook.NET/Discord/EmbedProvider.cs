using System;

namespace CSharpDiscordWebhook.NET.Discord
{
    public class EmbedProvider
    {
        /// <summary>
        /// Name of provider
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Url of provider
        /// </summary>
        public Uri Url { get; set; }
    }
}
