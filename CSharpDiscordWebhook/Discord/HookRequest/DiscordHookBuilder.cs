using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Discord.Webhook.HookRequest
{
    public class DiscordHookBuilder
    {
        string _bound;

        string _nick;
        string _avatar;

        JObject _json;

        /// <summary>
        /// Create hook request builder, can only be created using DiscordHookBuilder.Create()
        /// </summary>
        private DiscordHookBuilder(string Nickname, string AvatarUrl)
        {
            _bound = $"------------------------{DateTime.Now.Ticks.ToString("x")}";

            _nick = Nickname;
            _avatar = AvatarUrl;

            _json = new JObject();

            Embeds = new List<DiscordEmbed>();
        }

        /// <summary>
        /// Create a hook request builder
        /// </summary>
        /// <param name="Nickname">Webhook cusstom nickname</param>
        /// <param name="AvatarUrl">Webhook custom avatar</param>
        /// <returns></returns>
        public static DiscordHookBuilder Create(string Nickname=null, string AvatarUrl=null)
        {
            return new DiscordHookBuilder(Nickname, AvatarUrl);
        }

        /// <summary>
        /// Get or set the file to be uploaded
        /// </summary>
        public FileInfo FileUpload { get; set; }
        /// <summary>
        /// Get the embeds, embeds can be added using Embeds.Add()
        /// </summary>
        public List<DiscordEmbed> Embeds { get; private set; }
        /// <summary>
        /// Get or set the message content
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// If true, this message will be readed using TTS (only works if enabled on server, to hear the message the users need to be connected to the target channel)
        /// </summary>
        public bool  UseTTS { get; set; }

        /// <summary>
        /// Create hook request
        /// </summary>
        /// <returns>Hook request object</returns>
        public DiscordHook Build()
        {
            MemoryStream stream = new MemoryStream();

            byte[] boundary = Encoding.UTF8.GetBytes($"--{_bound}\r\n");
            stream.Write(boundary, 0, boundary.Length);

            if (FileUpload != null)
            {
                string uploadBody =
                        $"Content-Disposition: form-data; name=\"file\"; filename=\"{FileUpload.Name}\"\r\n" +
                        $"Content-Type: application/octet-stream\r\n\r\n";

                byte[] uploadBodyData = Encoding.UTF8.GetBytes(uploadBody);
                stream.Write(uploadBodyData, 0, uploadBodyData.Length);

                byte[] fileBuffer = File.ReadAllBytes(FileUpload.FullName);
                stream.Write(fileBuffer, 0, fileBuffer.Length);

                string uploadBodyEnd = $"\r\n--{_bound}\r\n";
                byte[] uploadBodyEndData = Encoding.UTF8.GetBytes(uploadBodyEnd);
                stream.Write(uploadBodyEndData, 0, uploadBodyEndData.Length);
            }

            _json.Add("username", _nick);
            _json.Add("avatar_url", _avatar);
            _json.Add("content", Message);
            _json.Add("tts", UseTTS);

            JArray embeds = new JArray();
            foreach(DiscordEmbed embed in Embeds) embeds.Add(embed.JsonData);
            if (embeds.Count > 0) _json.Add("embeds", embeds);

            string jsonBody = $"Content-Disposition: form-data; name=\"payload_json\"\r\n" +
                $"Content-Type: application/json\r\n\r\n" +
                $"{_json.ToString(Newtonsoft.Json.Formatting.None)}\r\n" +
                $"--{_bound}--";
            byte[] jsonBodyData = Encoding.UTF8.GetBytes(jsonBody);

            stream.Write(jsonBodyData, 0, jsonBodyData.Length);
            return new DiscordHook(stream, _bound);
        }
    }
}
