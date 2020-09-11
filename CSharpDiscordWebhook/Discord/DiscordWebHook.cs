using Discord.Webhook.HookRequest;
using System.Net;

namespace Discord.Webhook
{
    public class DiscordWebhook
    {
        /// <summary>
        /// Set or get webhook url
        /// </summary>
        public string HookUrl { get; set; }

        /// <summary>
        /// Create Webhook object
        /// </summary>
        public DiscordWebhook()
        {
            
        }

        /// <summary>
        /// Send webhook request
        /// </summary>
        /// <param name="HookRequest">Webhook request content</param>
        public void Hook(DiscordHook HookRequest)
        {
            WebClient client = new WebClient();
            client.Headers.Add("Content-Type", $"multipart/form-data; boundary={HookRequest.Boundary}");
            client.UploadData(HookUrl, HookRequest.Body.ToArray());
        }
    }
}
