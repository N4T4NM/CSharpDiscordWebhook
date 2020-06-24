using System;
using System.IO;
using System.Net;
using System.Text;

namespace Discord.Webhook.HookMessages
{
    public class DiscordFile : WebhookObject
    {
        string bound;
        string msg = "";
        string data = "";
        public DiscordFile(string Avatar = null, string Username = null) : base(Avatar, Username)
        {
            bound = "------------------------" + DateTime.Now.Ticks.ToString("x");
            this.ContentType = "multipart/form-data; boundary=" + bound;
            this.DataEncoding = Encoding.Default;
        }

        public void SetMessage(string Message)
        {
            msg = Message;
        }
        public void SetFiles(string[] Files)
        {
            var cli = new WebClient();
            cli.Encoding = Encoding.Default;
            data = "";
            for (int i = 0; i < 9 && i < Files.Length; i++)
            {
                FileInfo info = new FileInfo(Files[i]);

                var finfo = string.Format(
                "--{0}\r\n" +
                "Content-Disposition: form-data; name=\"file\"; filename=\"{1}\"\r\n" +
                "Content-Type: {2}\r\n\r\n" +
                "{3}\r\n", bound, info.Name, "application/octet-stream", cli.Encoding.GetString(File.ReadAllBytes(info.FullName)));
                data += finfo;
            }
        }

        public override string GetHook()
        {
            data += string.Format("--{0}\r\nContent-Disposition: form-data; name=\"{1}\"\r\n\r\n{2}\r\n", bound, "username", this.Username);
            data += string.Format("--{0}\r\nContent-Disposition: form-data; name=\"{1}\"\r\n\r\n{2}\r\n", bound, "avatar_url", this.Avatar);
            data += string.Format("--{0}\r\nContent-Disposition: form-data; name=\"{1}\"\r\n\r\n{2}\r\n", bound, "content", msg);
            data += string.Format("--{0}--", bound);
            return data;
        }
    }
}
