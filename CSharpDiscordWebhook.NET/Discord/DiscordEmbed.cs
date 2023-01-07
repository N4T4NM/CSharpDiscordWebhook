using System;
using System.Collections.Generic;

namespace CSharpDiscordWebhook.NET.Discord
{
    public class DiscordEmbed
    {
        /// <summary>
        /// Title of embed
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Description of embed
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Url of embed
        /// </summary>
        public Uri Url { get; set; }

        /// <summary>
        /// Timestamp of embed content
        /// </summary>
        public DiscordTimestamp Timestamp { get; set; }

        /// <summary>
        /// Color code of embed
        /// </summary>
        public DiscordColor Color { get; set; }

        /// <summary>
        /// Footer information
        /// </summary>
        public EmbedFooter Footer { get; set; }

        /// <summary>
        /// Image information
        /// </summary>
        public EmbedMedia Image { get; set; }

        /// <summary>
        /// Thumbnail information
        /// </summary>
        public EmbedMedia Thumbnail { get; set; }

        /// <summary>
        /// Video information
        /// </summary>
        public EmbedMedia Video { get; set; }


        /// <summary>
        /// Provider information
        /// </summary>
        public EmbedProvider Provider { get; set; }


        /// <summary>
        /// Author information
        /// </summary>
        public EmbedAuthor Author { get; set; }


        /// <summary>
        /// Fields information
        /// </summary>
        public List<EmbedField> Fields { get; set; } = new();
    }
}
