using System;

namespace CSharpDiscordWebhook.NET.Discord
{
    public class EmbedAuthor
    {
        /// <summary>
        /// Name of author
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Url of author
        /// </summary>
        public Uri Url { get; set; }

        /// <summary>
        /// Url of author icon(only supports http(s))
        /// </summary>
        public Uri IconUrl { get; set; }

        /// <summary>
        /// A proxied url of author icon
        /// </summary>
        public Uri ProxyIconUrl { get; set; }
    }
}
