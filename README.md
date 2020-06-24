# CSharpDiscordWebhook
Simple C# written code to send messages embeds and files using discord webhooks

***You need to add [NewtonSoft.Json](https://www.newtonsoft.com/json) to references.***<br><br>
**Code usage**
> Importing webhook code
```CSharp
using Discord.Webhook;
using Discord.Webhook.HookMessages;
```
> Creating webhook
```CSharp
DiscordWebhook hook = new DiscordWebhook();
hook.HookUrl = "https://...";
```

> Sending message
```CSharp
DiscordMessage message = new DiscordMessage(Avatar:"avatar-url", Username:"hook username");
message.SetMessage("your message");
hook.Hook(message);
```

> Sending embeds
```CSharp
DiscordEmbed embed = new DiscordEmbed(Avatar:"avatar-url", Username:"hook username");
embed.SetTitle("...");
embed.SetMessage("...");
embed.SetColor(Color.Red);
embed.SetImage("image-url");
embed.SetFooter("footer-text", "footer-image-url");
hook.Hook(embed);
```

> Sending files
```CSharp
DiscordFile file = new DiscordFile(Avatar:"avatar-url", Username:"hook username");
file.SetMessage("...");

//send files using code array
string[] FilesToSend = {"C:/...", "C:/...", "C:/..."};

//send user selected files
OpenFileDialog dialog = new OpenFileDialog();
dialog.Multiselect = true;
if(dialog.ShowDialog() == DialogResult.OK) {
  FilesToSend = dialog.FileNames;
}

hook.Hook(file);
```
