namespace CSharpDiscordWebhook.NET.Discord
{
    public sealed class AllowedMentionType
    {
        public static AllowedMentionType Role { get; } = new("Role");
        public static AllowedMentionType User { get; } = new("Users");
        public static AllowedMentionType Everyone { get; } = new("Everyone");

        public override string ToString() => _value;
        private AllowedMentionType(string value)
        {
            _value = value;
        }
        private readonly string _value;
    }
}
