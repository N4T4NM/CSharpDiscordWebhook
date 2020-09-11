using Discord.Webhook.HookRequest;
using System.Net;

namespace Discord.Webhook
{
    public class DiscordWebhook
    {
        public string HookUrl { get; set; }

        public DiscordWebhook()
        {
            
        }

        public void Hook(DiscordHook HookRequest)
        {
            WebClient client = new WebClient();
            client.Headers.Add("Content-Type", $"multipart/form-data; boundary={HookRequest.Boundary}");
            client.UploadData(HookUrl, HookRequest.Body.ToArray());
        }
    }
}
