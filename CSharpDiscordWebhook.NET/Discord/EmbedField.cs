namespace CSharpDiscordWebhook.NET.Discord
{
    public class EmbedField
    {
        /// <summary>
        /// Name of the field
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Value of the field
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Whether or not this field should display inline
        /// </summary>
        public bool Inline { get; set; }
    }
}
