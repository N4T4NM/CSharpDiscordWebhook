using System.Collections.Generic;

namespace CSharpDiscordWebhook.NET.Discord
{
    public class AllowedMention
    {
        /// <summary>
        /// An array of allowed mention types to parse from the content.
        /// </summary>
        public List<AllowedMentionType> Parse { get; } = new();

        /// <summary>
        /// Array of role_ids to mention (Max size of 100)
        /// </summary>
        public List<ulong> Roles { get; } = new();

        /// <summary>
        /// Array of user_ids to mention (Max size of 100)
        /// </summary>
        public List<ulong> Users { get; } = new();

        /// <summary>
        /// For replies, whether to mention the author of the message being replied to (default false)
        /// </summary>
        public bool RepliedUser { get; set; }
    }
}
