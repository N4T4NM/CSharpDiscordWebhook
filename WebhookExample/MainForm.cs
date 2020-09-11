using Discord.Utils;
using Discord.Webhook;
using Discord.Webhook.HookRequest;
using System;
using System.IO;
using System.Windows.Forms;

namespace WebhookExample
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }   

        DiscordWebhook hook;
        private void MainForm_Load(object sender, EventArgs e)
        {
            hook = new DiscordWebhook();
        }

        private void SelectFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = false;
            if(open.ShowDialog() == DialogResult.OK)
            {
                FileInfo info = new FileInfo(open.FileName);
                SelectFileButton.Tag = info;
                FileNameLbl.Text = $"Filename: {info.Name}";
            }
        }

        private void RemoveFileButton_Click(object sender, EventArgs e)
        {
            SelectFileButton.Tag = null;
            FileNameLbl.Text = "Filename: [NONE SELECTED]";
        }
        
        private void SendButton_Click(object sender, EventArgs e)
        {
            hook.HookUrl = this.HookURL.Text;

            DiscordHookBuilder builder = DiscordHookBuilder.Create(Nickname: HookNICK.Text, AvatarUrl: HookPIC.Text);
            builder.Message = HookMSG.Text;
            builder.FileUpload = SelectFileButton.Tag == null ? null : SelectFileButton.Tag as FileInfo;

            DiscordEmbed embed = new DiscordEmbed(
                Title: EmbedTitle.Text,
                Description: EmbedDescription.Text,
                Color: DiscordConverter.ColorToHex(EmbedColor.BackColor),
                ImageUrl: EmbedImage.Text, 
                FooterText: EmbedFooterText.Text,
                FooterIconUrl: EmbedFooterImage.Text);
            builder.Embeds.Add(embed);

            hook.Hook(builder.Build());
        }

        private void EmbedColor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EmbedColor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                EmbedColor.BackColor = dialog.Color;
            }
        }
    }
}
