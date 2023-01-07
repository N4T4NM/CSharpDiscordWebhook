using System;

namespace CSharpDiscordWebhook.NET.Discord
{
    public class EmbedMedia
    {
        /// <summary>
        /// Source url (only supports http(s))
        /// </summary>
        public Uri Url { get; set; }

        /// <summary>
        /// Proxy url of the media
        /// </summary>
        public Uri ProxyUrl { get; set; }

        /// <summary>
        /// Height of media
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// Width of media
        /// </summary>
        public int Width { get; set; }
    }
}
