# CSharpDiscordWebhook
Simple C# written code to send messages embeds and files using discord webhooks

***You need to add [NewtonSoft.Json](https://www.newtonsoft.com/json) to references.***<br><br>
**Code usage**
> Importing webhook code
```CSharp
using Discord.Webhook;
using Discord.Webhook.HookRequest;
```
> Creating webhook
```CSharp
DiscordWebhook hook = new DiscordWebhook();
hook.HookUrl = "https://discordapp.com/hook-url";
```

> Creating message
```CSharp
//create builder
DiscordHoolBuilder builder = DiscordHookBuilder.Create(Nickname: "Nickname", AvatarUrl: "http://url-to-image/image");
//set message
builder.Message = "Message Content";
//set file to upload
builder.FileUpload = new FileInfo("./file-location);

//add embed
DiscordEmbed embed = new DiscordEmbed(
                Title: "Embed Title",
                Description: "Embed Description",
                Color: 0xf54242, /*Set embed color to red*/
                ImageUrl: "Image Url", 
                FooterText: "Footer content",
                FooterIconUrl: "Footer Image Url");
builder.Embeds.Add(embed);
```

> Sending message
```CSharp
DiscordHook HookMessage = builder.Build();
hook.Hook(HookMessage);
```
