using System.IO;

namespace Discord.Webhook.HookRequest
{
    public class DiscordHook
    {
        internal DiscordHook(MemoryStream BodyData, string Bound)
        {
            this.Body = BodyData;
            this.Boundary = Bound;
        }

        public string Boundary { get; private set; }
        public MemoryStream Body { get; private set; }
    }
}
