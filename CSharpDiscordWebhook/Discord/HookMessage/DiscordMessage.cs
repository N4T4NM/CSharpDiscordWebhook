using System.Text;

namespace Discord.Webhook.HookMessages
{
    class DiscordMessage : WebhookObject
    {
        public DiscordMessage(string Avatar = null, string Username = null) : base(Avatar, Username)
        {
            this.ContentType = "application/json";
            this.DataEncoding = Encoding.UTF8;
            JsonData.Add("content", "");
        }

        public void SetMessage(string Message)
        {
            JsonData["content"] = Message;
        }

        public override string GetHook()
        {
            JsonData.Add("avatar_url", this.Avatar);
            JsonData.Add("username", this.Username);

            return JsonData.ToString();
        }
    }
}
