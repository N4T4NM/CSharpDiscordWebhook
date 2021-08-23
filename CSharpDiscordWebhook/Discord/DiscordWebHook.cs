using System;
using System.IO;
using System.Net;
using System.Text;

namespace Discord.Webhook
{
    public class DiscordWebhook
    {
        /// <summary>
        /// Webhook url
        /// </summary>
        public string Url { get; set; }

        private void AddField(MemoryStream stream, string bound, string cDisposition, string cType, byte[] data)
        {
            string prefix = stream.Length > 0 ? "\r\n--" : "--";
            string fBegin = $"{prefix}{bound}\r\n";

            byte[] fBeginBuffer = Utils.Encode(fBegin);
            byte[] cDispositionBuffer = Utils.Encode(cDisposition);
            byte[] cTypeBuffer = Utils.Encode(cType);

            stream.Write(fBeginBuffer, 0, fBeginBuffer.Length);
            stream.Write(cDispositionBuffer, 0, cDispositionBuffer.Length);
            stream.Write(cTypeBuffer, 0, cTypeBuffer.Length);
            stream.Write(data, 0, data.Length);
        }

        private void SetJsonPayload(MemoryStream stream, string bound, string json)
        {
            string cDisposition = "Content-Disposition: form-data; name=\"payload_json\"\r\n";
            string cType = "Content-Type: application/octet-stream\r\n\r\n";
            AddField(stream, bound, cDisposition, cType, Utils.Encode(json));
        }

        private void SetFile(MemoryStream stream, string bound, int index, FileInfo file)
        {
            string cDisposition = $"Content-Disposition: form-data; name=\"file_{index}\"; filename=\"{file.Name}\"\r\n";
            string cType = "Content-Type: application/octet-stream\r\n\r\n";
            AddField(stream, bound, cDisposition, cType, File.ReadAllBytes(file.FullName));
        }

        /// <summary>
        /// Send webhook message
        /// </summary>
        public void Send(DiscordMessage message, params FileInfo[] files)
        {
            if (string.IsNullOrEmpty(Url))
                throw new ArgumentNullException("Invalid Webhook URL.");

            string bound = "------------------------" + DateTime.Now.Ticks.ToString("x");
            WebClient webhookRequest = new WebClient();
            webhookRequest.Headers.Add("Content-Type", "multipart/form-data; boundary=" + bound);
            
            MemoryStream stream = new MemoryStream();
            for (int i = 0; i < files.Length; i++)
                SetFile(stream, bound, i, files[i]);

            string json = message.ToString();
            SetJsonPayload(stream, bound, json);

            byte[] bodyEnd = Utils.Encode($"\r\n--{bound}--");
            stream.Write(bodyEnd, 0, bodyEnd.Length);

            //byte[] beginBodyBuffer = Encoding.UTF8.GetBytes("--" + bound + "\r\n");
            //stream.Write(beginBodyBuffer, 0, beginBodyBuffer.Length);
            //bool flag = file != null && file.Exists;
            //if (flag)
            //{
            //    string fileBody = "Content-Disposition: form-data; name=\"file\"; filename=\"" + file.Name + "\"\r\nContent-Type: application/octet-stream\r\n\r\n";
            //    byte[] fileBodyBuffer = Encoding.UTF8.GetBytes(fileBody);
            //    stream.Write(fileBodyBuffer, 0, fileBodyBuffer.Length);
            //    byte[] fileBuffer = File.ReadAllBytes(file.FullName);
            //    stream.Write(fileBuffer, 0, fileBuffer.Length);
            //    string fileBodyEnd = "\r\n--" + bound + "\r\n";
            //    byte[] fileBodyEndBuffer = Encoding.UTF8.GetBytes(fileBodyEnd);
            //    stream.Write(fileBodyEndBuffer, 0, fileBodyEndBuffer.Length);
            //}
            //string jsonBody = string.Concat(new string[]
            //{
            //    "Content-Disposition: form-data; name=\"payload_json\"\r\nContent-Type: application/json\r\n\r\n",
            //    string.Format("{0}\r\n", message),
            //    "--",
            //    bound,
            //    "--"
            //});
            //byte[] jsonBodyBuffer = Encoding.UTF8.GetBytes(jsonBody);
            //stream.Write(jsonBodyBuffer, 0, jsonBodyBuffer.Length);

            try
            {
                webhookRequest.UploadData(this.Url, stream.ToArray());
            }
            catch (WebException ex)
            {
                throw new WebException(Utils.Decode(ex.Response.GetResponseStream()));
            }

            stream.Dispose();
        }
    }
}
