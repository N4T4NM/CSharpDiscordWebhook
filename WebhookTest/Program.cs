using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using CSharpDiscordWebhook.NET.Discord;

namespace WebhookTest
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.Write("Webhook URL > ");
            string url = Console.ReadLine();

#if DEBUGDNF || DEBUGFULL
            Console.WriteLine("Debugging DotNetFramwork...");
            var dnf = new DotNetFramework(url);
            dnf.TestMessage();
            dnf.TestFile();
            dnf.TestEmbed();
            dnf.TestError();

            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadKey();
#endif

#if DEBUGDN || DEBUGFULL
            Console.Clear();
            Console.WriteLine("Debugging DotNet...");
            var dn = new DotNet(url);
            await dn.TestMessageAsync();
            await dn.TestFileAsync();
            await dn.TestEmbedAsync();
            await dn.TestErrorAsync();

            Console.WriteLine("\n\nFinished. Press any key to exit...");
            Console.ReadKey();
#endif
            Environment.Exit(0);
        }
    }

    class DotNetFramework
    {
        Discord.Webhook.DiscordWebhook wb = new Discord.Webhook.DiscordWebhook();
        public DotNetFramework(string url)
        {
            wb.Url = url;
        }

        public void TestMessage()
        {
            Console.WriteLine("Testing message...");

            Discord.DiscordMessage msg = new Discord.DiscordMessage();
            msg.Content = "Message Test";
            wb.Send(msg);
        }

        public void TestFile()
        {
            Console.Write("Test File > ");
            var file = Console.ReadLine();
            
            if (string.IsNullOrEmpty(file) || !File.Exists(file))
            {
                Console.WriteLine("Jumping file test.");
                return;
            }

            FileInfo fInfo = new FileInfo(file);
            Console.WriteLine("Testing file...");
            Discord.DiscordMessage msg = new Discord.DiscordMessage();
            msg.Content = "File Test";

            wb.Send(msg, fInfo);
        }

        public void TestEmbed()
        {
            Console.WriteLine("Testing embeds...");
            Discord.DiscordMessage msg = new Discord.DiscordMessage();
            msg.Embeds = new List<Discord.DiscordEmbed>();
            msg.Embeds.Add(new Discord.DiscordEmbed()
            {
                Author = new Discord.EmbedAuthor() { Name = "NatanM" },
                Color = System.Drawing.Color.Red,
                Footer = new Discord.EmbedFooter() { Text = "Footer Test"},
                Fields = new List<Discord.EmbedField>() { new Discord.EmbedField() { Name = "Name", Value = "Value" } },
                Description = "Description",
                Title = "Title"
            });

            wb.Send(msg);
        }

        public void TestError()
        {
            Console.WriteLine("Testing error...");

            Discord.DiscordMessage msg = new Discord.DiscordMessage();
            msg.AvatarUrl = "InvalidAvatarUrl";
            msg.Embeds = new List<Discord.DiscordEmbed>();
            msg.Embeds.Add(new Discord.DiscordEmbed() { Url = "InvalidEmbedUrl", Image=new Discord.EmbedMedia() { Url = "Invalid image url" } });
            try
            {
                wb.Send(msg);
                throw new InvalidOperationException("Expected web exception !!");
            } catch(WebException ex)
            {
                Console.WriteLine($"Server response: {ex.Message}");
            }
        }
    }
    class DotNet
    {
        private DiscordWebhook wb;
        public DotNet(string url)
        {
            wb = new DiscordWebhook
            {
                Uri = new Uri(url)
            };
        }

        public async Task TestMessageAsync()
        {
            Console.WriteLine("Testing message...");

            DiscordMessage msg = new DiscordMessage();
            msg.Content = "Message Test";
            await wb.SendAsync(msg);
        }
        public async Task TestFileAsync()
        {
            Console.Write("Test Files > ");
            var files = Console.ReadLine();
            List<FileInfo> fInfos = new List<FileInfo>();
            foreach(string fl in files.Split(';'))
                fInfos.Add(new FileInfo(fl));

            Console.WriteLine("Testing files...");
            DiscordMessage msg = new DiscordMessage();
            msg.Content = "File Test";

            await wb.SendAsync(msg, fInfos.ToArray());
        }

        public async Task TestEmbedAsync()
        {
            Console.WriteLine("Testing embeds...");
            DiscordMessage msg = new DiscordMessage();
            msg.Embeds.Add(new DiscordEmbed()
            {
                Author = new EmbedAuthor() { Name = "NatanM" },
                Color = System.Drawing.Color.Red,
                Footer = new EmbedFooter() { Text = "Footer Test" },
                Fields = new List<EmbedField>() { new EmbedField() { Name = "Name", Value = "Value" } },
                Description = "Description",
                Title = "Title"
            });

            await wb.SendAsync(msg);
        }

        public async Task TestErrorAsync()
        {
            Console.WriteLine("Testing error...");

            DiscordMessage msg = new DiscordMessage();
            msg.AvatarUrl = "InvalidAvatarUrl";
            msg.Embeds.Add(new DiscordEmbed() { Url = "InvalidEmbedUrl", Image = new EmbedMedia() { Url = "Invalid image url" } });
            try
            {
                await wb.SendAsync(msg);
                throw new InvalidOperationException("Expected discord exception !!");
            }
            catch (DiscordException ex)
            {
                Console.WriteLine($"Server response: {ex.Message}");
            }
        }
    }
}
