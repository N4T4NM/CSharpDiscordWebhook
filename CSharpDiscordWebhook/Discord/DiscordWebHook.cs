using System.Net;

namespace Discord.Webhook
{
    class DiscordWebhook
    {
        public string HookUrl { get; set; }
        WebClient client;

        public DiscordWebhook()
        {
            client = new WebClient();
        }

        public void Hook(WebhookObject HookObject)
        {
            client.Encoding = HookObject.DataEncoding;
            client.Headers.Add("Content-Type", HookObject.ContentType);
            byte[] request = client.Encoding.GetBytes(HookObject.GetHook());
            client.UploadData(HookUrl, "POST", request);
        }
    }
}
