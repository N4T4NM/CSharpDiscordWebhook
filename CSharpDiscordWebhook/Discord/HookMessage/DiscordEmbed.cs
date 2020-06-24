using Newtonsoft.Json.Linq;
using System.Text;

namespace Discord.Webhook.HookMessages
{
    class DiscordEmbed : WebhookObject
    {
        public DiscordEmbed(string Avatar = null, string Username = null) : base(Avatar, Username)
        {
            this.ContentType = "application/json";
            this.DataEncoding = Encoding.UTF8;

            var embedData = new JObject();
            embedData.Add("title", "");
            embedData.Add("description", "");
            embedData.Add("color", 0);

            var imageData = new JObject();
            imageData.Add("url", "");
            var footerData = new JObject();
            footerData.Add("text", "");
            footerData.Add("icon_url", "");

            embedData.Add("image", imageData);
            embedData.Add("footer", footerData);

            JsonData.Add("embeds", new JArray(embedData));
        }

        public void SetTitle(string Title)
        {
            var arr = (JArray)JsonData["embeds"];
            arr[0]["title"] = Title;
        }

        public void SetMessage(string Message)
        {
            var arr = (JArray)JsonData["embeds"];
            arr[0]["description"] = Message;
        }

        public void SetColor(int Color)
        {
            var arr = (JArray)JsonData["embeds"];
            arr[0]["color"] = Color;
        }

        public void SetImage(string URL)
        {
            var arr = (JArray)JsonData["embeds"];
            var imageData = (JObject)arr[0]["image"];
            imageData["url"] = URL;
        }

        public void SetFooter(string Content, string Icon)
        {
            var arr = (JArray)JsonData["embeds"];
            var footerData = (JObject)arr[0]["footer"];
            footerData["text"] = Content;
            footerData["icon_url"] = Icon;
        }

        public override string GetHook()
        {
            JsonData.Add("avatar_url", this.Avatar);
            JsonData.Add("username", this.Username);

            return JsonData.ToString();
        }
    }
}
