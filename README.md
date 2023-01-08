# CSharpDiscordWebhook
Simple C# written code to send messages embeds and files using discord webhooks

[![Patreon](https://badgen.net/badge/icon/patreon?icon=patreon&label=Support)](https://patreon.com/natanm)
[![NuGet](https://badgen.net/badge/icon/nuget?icon=nuget&label=Package)](https://www.nuget.org/packages/CSharpDiscordWebhook.NET/)

***If you are using the .NET Framework version, you need to add [NewtonSoft.Json](https://www.newtonsoft.com/json) to references.***<br><br>

**Code usage .NET**
> Importing webhook code
```CSharp
using CSharpDiscordWebhook.NET.Discord;
```
> Creating webhook
```CSharp
DiscordWebhook hook = new DiscordWebhook();
hook.Uri = new Uri("https://discordapp.com/hook-url");
```

> Creating message
```CSharp
DiscordMessage message = new DiscordMessage();
message.Content = "Example message, ping @everyone, <@userid>";
message.TTS = true; //read message to everyone on the channel
message.Username = "Webhook username";
message.AvatarUrl = "http://url-of-image";

//embeds
DiscordEmbed embed = new DiscordEmbed();
embed.Title = "Embed title";
embed.Description = "Embed description";
embed.Url = new Uri("Embed Url");
embed.Timestamp = new DiscordTimestamp(DateTime.Now);
embed.Color = new DiscordColor(Color.Red); //alpha will be ignored, you can use any RGB color
embed.Footer = new EmbedFooter() {Text="Footer Text", IconUrl = new Uri("http://url-of-image")};
embed.Image = new EmbedMedia() {Url= new Uri("Media URL"), Width=150, Height=150}; //valid for thumb and video
embed.Provider = new EmbedProvider() {Name="Provider Name", Url=new Uri("Provider Url") };
embed.Author = new EmbedAuthor() {Name="Author Name", Url= new Uri("Author Url"), IconUrl=new Uri("http://url-of-image")};

//fields
embed.Fields = new List<EmbedField>();
embed.Fields.Add(new EmbedField() {Name="Field Name", Value="Field Value", InLine=true });
embed.Fields.Add(new EmbedField() {Name="Field Name 2", Value="Field Value 2", InLine=true });

//set embed
message.Embeds = new List<DiscordEmbed>();
message.Embeds.Add(embed);

//Allowed mentions
message.AllowedMentions = new AllowedMentions();

message.AllowedMentions.Parse.Add(AllowedMentionType.Role); //Allow role mentions
message.AllowedMentions.Parse.Add(AllowedMentionType.User); //Allow user mentions
message.AllowedMentions.Parse.Add(AllowedMentionType.Everyone); //Allow @everyone mentions]

message.AllowedMentions.Roles = new List<ulong>();
message.AllowedMentions.Roles.Add(000000000000000000); //Allow mention the role with this id

message.AllowedMentions.Users = new List<ulong>();
message.AllowedMentions.Users.Add(000000000000000000); //Allow mention the user this this id
```

> Sending message
```CSharp

//message
await hook.SendAsync(message);

//file
await hook.SendAsync(message, new FileInfo("C:/File/Path.file"));
```

<br><br>
**Code usage .Net Framework**
> Importing webhook code
```CSharp
using Discord;
using Discord.Webhook;
```
> Creating webhook
```CSharp
DiscordWebhook hook = new DiscordWebhook();
hook.Url = "https://discordapp.com/hook-url";
```

> Creating message
```CSharp
DiscordMessage message = new DiscordMessage();
message.Content = "Example message, ping @everyone, <@userid>";
message.TTS = true; //read message to everyone on the channel
message.Username = "Webhook username";
message.AvatarUrl = "http://url-of-image";

//embeds
DiscordEmbed embed = new DiscordEmbed();
embed.Title = "Embed title";
embed.Description = "Embed description";
embed.Url = "Embed Url";
embed.Timestamp = DateTime.Now;
embed.Color = Color.Red; //alpha will be ignored, you can use any RGB color
embed.Footer = new EmbedFooter() {Text="Footer Text", IconUrl="http://url-of-image"};
embed.Image = new EmbedMedia() {Url="Media URL", Width=150, Height=150}; //valid for thumb and video
embed.Provider = new EmbedProvider() {Name="Provider Name", Url="Provider Url"};
embed.Author = new EmbedAuthor() {Name="Author Name", Url="Author Url", IconUrl="http://url-of-image"};

//fields
embed.Fields = new List<EmbedField>();
embed.Fields.Add(new EmbedField() {Name="Field Name", Value="Field Value", InLine=true });
embed.Fields.Add(new EmbedField() {Name="Field Name 2", Value="Field Value 2", InLine=true });

//set embed
message.Embeds = new List<DiscordEmbed>();
message.Embeds.Add(embed);

//
```

> Sending message
```CSharp

//message
hook.Send(message);

//file
hook.Send(message, new FileInfo("C:/File/Path.file"));
```
