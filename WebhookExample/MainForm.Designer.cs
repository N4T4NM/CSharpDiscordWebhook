namespace WebhookExample
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HookURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HookNICK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.HookPIC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.HookMSG = new System.Windows.Forms.TextBox();
            this.FileNameLbl = new System.Windows.Forms.Label();
            this.SelectFileButton = new System.Windows.Forms.Button();
            this.SendButton = new System.Windows.Forms.Button();
            this.RemoveFileButton = new System.Windows.Forms.Button();
            this.EmbedTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EmbedDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.EmbedImage = new System.Windows.Forms.TextBox();
            this.EmbedFooterImage = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.EmbedFooterText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.EmbedColor = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // HookURL
            // 
            this.HookURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HookURL.Location = new System.Drawing.Point(12, 27);
            this.HookURL.Name = "HookURL";
            this.HookURL.Size = new System.Drawing.Size(934, 23);
            this.HookURL.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nickname";
            // 
            // HookNICK
            // 
            this.HookNICK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HookNICK.Location = new System.Drawing.Point(12, 87);
            this.HookNICK.Name = "HookNICK";
            this.HookNICK.Size = new System.Drawing.Size(309, 23);
            this.HookNICK.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Picture URL";
            // 
            // HookPIC
            // 
            this.HookPIC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HookPIC.Location = new System.Drawing.Point(336, 87);
            this.HookPIC.Name = "HookPIC";
            this.HookPIC.Size = new System.Drawing.Size(452, 23);
            this.HookPIC.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Message";
            // 
            // HookMSG
            // 
            this.HookMSG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HookMSG.Location = new System.Drawing.Point(12, 147);
            this.HookMSG.Multiline = true;
            this.HookMSG.Name = "HookMSG";
            this.HookMSG.Size = new System.Drawing.Size(309, 292);
            this.HookMSG.TabIndex = 0;
            // 
            // FileNameLbl
            // 
            this.FileNameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FileNameLbl.AutoSize = true;
            this.FileNameLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FileNameLbl.Location = new System.Drawing.Point(336, 147);
            this.FileNameLbl.Name = "FileNameLbl";
            this.FileNameLbl.Size = new System.Drawing.Size(208, 21);
            this.FileNameLbl.TabIndex = 3;
            this.FileNameLbl.Text = "Filename: [NONE SELECTED]";
            // 
            // SelectFileButton
            // 
            this.SelectFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectFileButton.Location = new System.Drawing.Point(341, 171);
            this.SelectFileButton.Name = "SelectFileButton";
            this.SelectFileButton.Size = new System.Drawing.Size(75, 23);
            this.SelectFileButton.TabIndex = 4;
            this.SelectFileButton.Text = "Select";
            this.SelectFileButton.UseVisualStyleBackColor = true;
            this.SelectFileButton.Click += new System.EventHandler(this.SelectFileButton_Click);
            // 
            // SendButton
            // 
            this.SendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SendButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SendButton.Location = new System.Drawing.Point(818, 404);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(128, 35);
            this.SendButton.TabIndex = 4;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // RemoveFileButton
            // 
            this.RemoveFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveFileButton.Location = new System.Drawing.Point(422, 171);
            this.RemoveFileButton.Name = "RemoveFileButton";
            this.RemoveFileButton.Size = new System.Drawing.Size(69, 23);
            this.RemoveFileButton.TabIndex = 4;
            this.RemoveFileButton.Text = "Remove";
            this.RemoveFileButton.UseVisualStyleBackColor = true;
            this.RemoveFileButton.Click += new System.EventHandler(this.RemoveFileButton_Click);
            // 
            // EmbedTitle
            // 
            this.EmbedTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EmbedTitle.Location = new System.Drawing.Point(336, 229);
            this.EmbedTitle.Name = "EmbedTitle";
            this.EmbedTitle.Size = new System.Drawing.Size(305, 23);
            this.EmbedTitle.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Embed Title";
            // 
            // EmbedDescription
            // 
            this.EmbedDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EmbedDescription.Location = new System.Drawing.Point(336, 273);
            this.EmbedDescription.Multiline = true;
            this.EmbedDescription.Name = "EmbedDescription";
            this.EmbedDescription.Size = new System.Drawing.Size(305, 165);
            this.EmbedDescription.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(336, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Embed Description";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(647, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Image Url";
            // 
            // EmbedImage
            // 
            this.EmbedImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EmbedImage.Location = new System.Drawing.Point(647, 229);
            this.EmbedImage.Name = "EmbedImage";
            this.EmbedImage.Size = new System.Drawing.Size(305, 23);
            this.EmbedImage.TabIndex = 0;
            // 
            // EmbedFooterImage
            // 
            this.EmbedFooterImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EmbedFooterImage.Location = new System.Drawing.Point(647, 273);
            this.EmbedFooterImage.Name = "EmbedFooterImage";
            this.EmbedFooterImage.Size = new System.Drawing.Size(305, 23);
            this.EmbedFooterImage.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(647, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Footer Image Url";
            // 
            // EmbedFooterText
            // 
            this.EmbedFooterText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EmbedFooterText.Location = new System.Drawing.Point(647, 328);
            this.EmbedFooterText.Name = "EmbedFooterText";
            this.EmbedFooterText.Size = new System.Drawing.Size(305, 23);
            this.EmbedFooterText.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(647, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Footer Text";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(647, 368);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Embed Color";
            // 
            // EmbedColor
            // 
            this.EmbedColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EmbedColor.BackColor = System.Drawing.Color.Red;
            this.EmbedColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EmbedColor.Location = new System.Drawing.Point(647, 386);
            this.EmbedColor.Name = "EmbedColor";
            this.EmbedColor.Size = new System.Drawing.Size(73, 52);
            this.EmbedColor.TabIndex = 5;
            this.EmbedColor.Click += new System.EventHandler(this.EmbedColor_Click);
            this.EmbedColor.Paint += new System.Windows.Forms.PaintEventHandler(this.EmbedColor_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 451);
            this.Controls.Add(this.EmbedColor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.EmbedFooterText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.EmbedFooterImage);
            this.Controls.Add(this.EmbedImage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EmbedDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EmbedTitle);
            this.Controls.Add(this.RemoveFileButton);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.SelectFileButton);
            this.Controls.Add(this.FileNameLbl);
            this.Controls.Add(this.HookMSG);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HookPIC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HookNICK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HookURL);
            this.Name = "MainForm";
            this.Text = "Webhook Example";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HookURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox HookNICK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox HookPIC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox HookMSG;
        private System.Windows.Forms.Label FileNameLbl;
        private System.Windows.Forms.Button SelectFileButton;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button RemoveFileButton;
        private System.Windows.Forms.TextBox EmbedTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EmbedDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox EmbedImage;
        private System.Windows.Forms.TextBox EmbedFooterImage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox EmbedFooterText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel EmbedColor;
    }
}