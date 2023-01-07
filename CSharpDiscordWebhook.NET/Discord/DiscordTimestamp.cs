using System;

namespace CSharpDiscordWebhook.NET.Discord
{
    public class DiscordTimestamp
    {
        public DateTime Time { get; set; }

        public DiscordTimestamp(string ts) : this(DateTime.Parse(ts))
        {

        }
        public DiscordTimestamp(DateTime time)
        {
            Time = time;
        }
        public override string ToString() => Time.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz");
    }
}
