using Newtonsoft.Json.Linq;
using System.Text;

namespace Discord.Webhook
{
    public class WebhookObject
    {
        public string Avatar { get; private set; }
        public string Username { get; private set; }
        public Encoding DataEncoding { get; internal set; }
        public string ContentType { get; internal set; }
        internal JObject JsonData;

        public WebhookObject(string Avatar = null, string Username = null)
        {
            this.Avatar = Avatar;
            this.Username = Username;
            JsonData = new JObject();
        }

        public virtual string GetHook() { return ""; }
    }
}
