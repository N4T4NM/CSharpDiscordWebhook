using System;

namespace CSharpDiscordWebhook.NET.Discord
{
    public class EmbedFooter
    {
        /// <summary>
        /// Footer text
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Url of footer icon (only supports http(s))
        /// </summary>
        public Uri IconUrl { get; set; }

        /// <summary>
        /// A proxied url of footer icon
        /// </summary>
        public Uri ProxyIconUrl { get; set; }
    }
}
