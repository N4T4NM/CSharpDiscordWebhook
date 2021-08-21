using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace WebhookTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Webhook URL > ");
            string url = Console.ReadLine();

            var dnf = new DotNetFramework(url);
            dnf.TestMessage();
            dnf.TestFile();
            dnf.TestEmbed();
            dnf.TestError();

            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadKey();

            Console.Clear();
            var dn = new DotNet(url);
            dn.TestMessage();
            dn.TestFile();
            dn.TestEmbed();
            dn.TestError();

            Console.WriteLine("\n\nFinished. Press any key to exit...");
            Console.ReadKey();
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
        Discord.NET.Webhook.DiscordWebhook wb = new Discord.NET.Webhook.DiscordWebhook();
        public DotNet(string url)
        {
            wb.Url = url;
        }

        public void TestMessage()
        {
            Console.WriteLine("Testing message...");

            Discord.NET.DiscordMessage msg = new Discord.NET.DiscordMessage();
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
            Discord.NET.DiscordMessage msg = new Discord.NET.DiscordMessage();
            msg.Content = "File Test";

            wb.Send(msg, fInfo);
        }

        public void TestEmbed()
        {
            Console.WriteLine("Testing embeds...");
            Discord.NET.DiscordMessage msg = new Discord.NET.DiscordMessage();
            msg.Embeds.Add(new Discord.NET.DiscordEmbed()
            {
                Author = new Discord.NET.EmbedAuthor() { Name = "NatanM" },
                Color = System.Drawing.Color.Red,
                Footer = new Discord.NET.EmbedFooter() { Text = "Footer Test" },
                Fields = new List<Discord.NET.EmbedField>() { new Discord.NET.EmbedField() { Name = "Name", Value = "Value" } },
                Description = "Description",
                Title = "Title"
            });

            wb.Send(msg);
        }

        public void TestError()
        {
            Console.WriteLine("Testing error...");

            Discord.NET.DiscordMessage msg = new Discord.NET.DiscordMessage();
            msg.AvatarUrl = "InvalidAvatarUrl";
            msg.Embeds.Add(new Discord.NET.DiscordEmbed() { Url = "InvalidEmbedUrl", Image = new Discord.NET.EmbedMedia() { Url = "Invalid image url" } });
            try
            {
                wb.Send(msg);
                throw new InvalidOperationException("Expected web exception !!");
            }
            catch (WebException ex)
            {
                Console.WriteLine($"Server response: {ex.Message}");
            }
        }
    }
}
