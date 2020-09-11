using Newtonsoft.Json.Linq;

namespace Discord.Webhook.HookRequest
{
    public class DiscordEmbed
    {
        public DiscordEmbed(string Title="", string Description="", 
            int Color=0, string ImageUrl="", string FooterText="", string FooterIconUrl="")
        {

            var embedData = new JObject();
            embedData.Add("title", Title);
            embedData.Add("description", Description);
            embedData.Add("color", Color);

            var imageData = new JObject();
            imageData.Add("url", ImageUrl);

            var footerData = new JObject();
            footerData.Add("text", FooterText);
            footerData.Add("icon_url", FooterIconUrl);

            embedData.Add("image", imageData);
            embedData.Add("footer", footerData);

            JsonData = embedData;
        }

        public JObject JsonData { get; private set; }
    }
}
