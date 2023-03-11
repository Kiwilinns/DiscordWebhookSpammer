namespace DiscordWebhookSpammer
{
    partial class spammerForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(spammerForm));
            this.titleLabel = new Guna.UI.WinForms.GunaLabel();
            this.labelbgElipse = new Guna.UI.WinForms.GunaElipse(this.components);
            this.webhookListBox = new System.Windows.Forms.ListBox();
            this.webhooklstbxElipse = new Guna.UI.WinForms.GunaElipse(this.components);
            this.reloadwebhookButton = new Guna.UI.WinForms.GunaButton();
            this.reloadnicknamesButton = new Guna.UI.WinForms.GunaButton();
            this.nicknameListBox = new System.Windows.Forms.ListBox();
            this.formElipse = new Guna.UI.WinForms.GunaElipse(this.components);
            this.nicknamelstbxElipse = new Guna.UI.WinForms.GunaElipse(this.components);
            this.webhookandnicknamePanel = new Guna.UI.WinForms.GunaPanel();
            this.singleSettingsCheckBox = new Guna.UI.WinForms.GunaCheckBox();
            this.nicknameTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.webhookTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.startButton = new Guna.UI.WinForms.GunaButton();
            this.messageTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.opentxtButton = new Guna.UI.WinForms.GunaButton();
            this.clearButton = new Guna.UI.WinForms.GunaButton();
            this.setforecolorButton = new Guna.UI.WinForms.GunaButton();
            this.delayLabel = new Guna.UI.WinForms.GunaLabel();
            this.titlelabelDragControl = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.stopButton = new Guna.UI.WinForms.GunaButton();
            this.spammerTimer = new System.Windows.Forms.Timer(this.components);
            this.delayTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.webhookandnicknamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.titleLabel.Font = new System.Drawing.Font("Century Gothic", 32F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.Silver;
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(776, 110);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "DiscordWebhook\r\nSpammer";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelbgElipse
            // 
            this.labelbgElipse.Radius = 10;
            this.labelbgElipse.TargetControl = this.titleLabel;
            // 
            // webhookListBox
            // 
            this.webhookListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.webhookListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.webhookListBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.webhookListBox.ForeColor = System.Drawing.Color.White;
            this.webhookListBox.FormattingEnabled = true;
            this.webhookListBox.ItemHeight = 19;
            this.webhookListBox.Location = new System.Drawing.Point(3, 1);
            this.webhookListBox.Name = "webhookListBox";
            this.webhookListBox.Size = new System.Drawing.Size(231, 114);
            this.webhookListBox.TabIndex = 3;
            // 
            // webhooklstbxElipse
            // 
            this.webhooklstbxElipse.Radius = 5;
            this.webhooklstbxElipse.TargetControl = this.webhookListBox;
            // 
            // reloadwebhookButton
            // 
            this.reloadwebhookButton.Animated = true;
            this.reloadwebhookButton.AnimationHoverSpeed = 0.07F;
            this.reloadwebhookButton.AnimationSpeed = 0.03F;
            this.reloadwebhookButton.BackColor = System.Drawing.Color.Transparent;
            this.reloadwebhookButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.reloadwebhookButton.BorderColor = System.Drawing.Color.Silver;
            this.reloadwebhookButton.BorderSize = 1;
            this.reloadwebhookButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.reloadwebhookButton.FocusedColor = System.Drawing.Color.Empty;
            this.reloadwebhookButton.Font = new System.Drawing.Font("Century Gothic", 14.75F, System.Drawing.FontStyle.Bold);
            this.reloadwebhookButton.ForeColor = System.Drawing.Color.White;
            this.reloadwebhookButton.Image = null;
            this.reloadwebhookButton.ImageSize = new System.Drawing.Size(20, 20);
            this.reloadwebhookButton.Location = new System.Drawing.Point(3, 121);
            this.reloadwebhookButton.Name = "reloadwebhookButton";
            this.reloadwebhookButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.reloadwebhookButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.reloadwebhookButton.OnHoverForeColor = System.Drawing.Color.White;
            this.reloadwebhookButton.OnHoverImage = null;
            this.reloadwebhookButton.OnPressedColor = System.Drawing.Color.Black;
            this.reloadwebhookButton.Radius = 10;
            this.reloadwebhookButton.Size = new System.Drawing.Size(231, 41);
            this.reloadwebhookButton.TabIndex = 4;
            this.reloadwebhookButton.Text = "Reload";
            this.reloadwebhookButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.reloadwebhookButton.Click += new System.EventHandler(this.reloadwebhookButton_Click);
            // 
            // reloadnicknamesButton
            // 
            this.reloadnicknamesButton.Animated = true;
            this.reloadnicknamesButton.AnimationHoverSpeed = 0.07F;
            this.reloadnicknamesButton.AnimationSpeed = 0.03F;
            this.reloadnicknamesButton.BackColor = System.Drawing.Color.Transparent;
            this.reloadnicknamesButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.reloadnicknamesButton.BorderColor = System.Drawing.Color.Silver;
            this.reloadnicknamesButton.BorderSize = 1;
            this.reloadnicknamesButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.reloadnicknamesButton.FocusedColor = System.Drawing.Color.Empty;
            this.reloadnicknamesButton.Font = new System.Drawing.Font("Century Gothic", 14.75F, System.Drawing.FontStyle.Bold);
            this.reloadnicknamesButton.ForeColor = System.Drawing.Color.White;
            this.reloadnicknamesButton.Image = null;
            this.reloadnicknamesButton.ImageSize = new System.Drawing.Size(20, 20);
            this.reloadnicknamesButton.Location = new System.Drawing.Point(3, 287);
            this.reloadnicknamesButton.Name = "reloadnicknamesButton";
            this.reloadnicknamesButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.reloadnicknamesButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.reloadnicknamesButton.OnHoverForeColor = System.Drawing.Color.White;
            this.reloadnicknamesButton.OnHoverImage = null;
            this.reloadnicknamesButton.OnPressedColor = System.Drawing.Color.Black;
            this.reloadnicknamesButton.Radius = 10;
            this.reloadnicknamesButton.Size = new System.Drawing.Size(231, 41);
            this.reloadnicknamesButton.TabIndex = 6;
            this.reloadnicknamesButton.Text = "Reload";
            this.reloadnicknamesButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.reloadnicknamesButton.Click += new System.EventHandler(this.reloadnicknamesButton_Click);
            // 
            // nicknameListBox
            // 
            this.nicknameListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.nicknameListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nicknameListBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nicknameListBox.ForeColor = System.Drawing.Color.White;
            this.nicknameListBox.FormattingEnabled = true;
            this.nicknameListBox.ItemHeight = 19;
            this.nicknameListBox.Location = new System.Drawing.Point(3, 167);
            this.nicknameListBox.Name = "nicknameListBox";
            this.nicknameListBox.Size = new System.Drawing.Size(231, 114);
            this.nicknameListBox.TabIndex = 5;
            // 
            // formElipse
            // 
            this.formElipse.Radius = 5;
            this.formElipse.TargetControl = this;
            // 
            // nicknamelstbxElipse
            // 
            this.nicknamelstbxElipse.Radius = 5;
            this.nicknamelstbxElipse.TargetControl = this.nicknameListBox;
            // 
            // webhookandnicknamePanel
            // 
            this.webhookandnicknamePanel.Controls.Add(this.webhookListBox);
            this.webhookandnicknamePanel.Controls.Add(this.reloadnicknamesButton);
            this.webhookandnicknamePanel.Controls.Add(this.reloadwebhookButton);
            this.webhookandnicknamePanel.Controls.Add(this.nicknameListBox);
            this.webhookandnicknamePanel.Enabled = false;
            this.webhookandnicknamePanel.Location = new System.Drawing.Point(551, 125);
            this.webhookandnicknamePanel.Name = "webhookandnicknamePanel";
            this.webhookandnicknamePanel.Size = new System.Drawing.Size(237, 330);
            this.webhookandnicknamePanel.TabIndex = 7;
            // 
            // singleSettingsCheckBox
            // 
            this.singleSettingsCheckBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.singleSettingsCheckBox.Checked = true;
            this.singleSettingsCheckBox.CheckedOffColor = System.Drawing.Color.Gray;
            this.singleSettingsCheckBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.singleSettingsCheckBox.FillColor = System.Drawing.Color.White;
            this.singleSettingsCheckBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.singleSettingsCheckBox.ForeColor = System.Drawing.Color.White;
            this.singleSettingsCheckBox.Location = new System.Drawing.Point(380, 126);
            this.singleSettingsCheckBox.Name = "singleSettingsCheckBox";
            this.singleSettingsCheckBox.Size = new System.Drawing.Size(145, 23);
            this.singleSettingsCheckBox.TabIndex = 8;
            this.singleSettingsCheckBox.Text = "Single Settings";
            this.singleSettingsCheckBox.CheckedChanged += new System.EventHandler(this.singleSettingsCheckBox_CheckedChanged);
            // 
            // nicknameTextBox
            // 
            this.nicknameTextBox.BackColor = System.Drawing.Color.Transparent;
            this.nicknameTextBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.nicknameTextBox.BorderColor = System.Drawing.Color.Silver;
            this.nicknameTextBox.BorderSize = 1;
            this.nicknameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nicknameTextBox.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.nicknameTextBox.FocusedBorderColor = System.Drawing.Color.White;
            this.nicknameTextBox.FocusedForeColor = System.Drawing.Color.Silver;
            this.nicknameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nicknameTextBox.ForeColor = System.Drawing.Color.White;
            this.nicknameTextBox.Location = new System.Drawing.Point(380, 191);
            this.nicknameTextBox.Name = "nicknameTextBox";
            this.nicknameTextBox.PasswordChar = '\0';
            this.nicknameTextBox.Radius = 5;
            this.nicknameTextBox.SelectedText = "";
            this.nicknameTextBox.Size = new System.Drawing.Size(161, 30);
            this.nicknameTextBox.TabIndex = 10;
            this.nicknameTextBox.Text = "Nickname";
            this.nicknameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // webhookTextBox
            // 
            this.webhookTextBox.BackColor = System.Drawing.Color.Transparent;
            this.webhookTextBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.webhookTextBox.BorderColor = System.Drawing.Color.Silver;
            this.webhookTextBox.BorderSize = 1;
            this.webhookTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.webhookTextBox.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.webhookTextBox.FocusedBorderColor = System.Drawing.Color.White;
            this.webhookTextBox.FocusedForeColor = System.Drawing.Color.Silver;
            this.webhookTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.webhookTextBox.ForeColor = System.Drawing.Color.White;
            this.webhookTextBox.Location = new System.Drawing.Point(380, 155);
            this.webhookTextBox.Name = "webhookTextBox";
            this.webhookTextBox.PasswordChar = '\0';
            this.webhookTextBox.Radius = 5;
            this.webhookTextBox.SelectedText = "";
            this.webhookTextBox.Size = new System.Drawing.Size(161, 30);
            this.webhookTextBox.TabIndex = 11;
            this.webhookTextBox.Text = "Webhook";
            this.webhookTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // startButton
            // 
            this.startButton.Animated = true;
            this.startButton.AnimationHoverSpeed = 0.07F;
            this.startButton.AnimationSpeed = 0.03F;
            this.startButton.BackColor = System.Drawing.Color.Transparent;
            this.startButton.BaseColor = System.Drawing.Color.Green;
            this.startButton.BorderColor = System.Drawing.Color.Silver;
            this.startButton.BorderSize = 1;
            this.startButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.startButton.FocusedColor = System.Drawing.Color.Empty;
            this.startButton.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold);
            this.startButton.ForeColor = System.Drawing.Color.White;
            this.startButton.Image = null;
            this.startButton.ImageSize = new System.Drawing.Size(20, 20);
            this.startButton.Location = new System.Drawing.Point(380, 356);
            this.startButton.Name = "startButton";
            this.startButton.OnHoverBaseColor = System.Drawing.Color.DarkGreen;
            this.startButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.startButton.OnHoverForeColor = System.Drawing.Color.White;
            this.startButton.OnHoverImage = null;
            this.startButton.OnPressedColor = System.Drawing.Color.Black;
            this.startButton.Radius = 10;
            this.startButton.Size = new System.Drawing.Size(161, 46);
            this.startButton.TabIndex = 7;
            this.startButton.Text = "Start";
            this.startButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // messageTextBox
            // 
            this.messageTextBox.BackColor = System.Drawing.Color.Transparent;
            this.messageTextBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.messageTextBox.BorderColor = System.Drawing.Color.Silver;
            this.messageTextBox.BorderSize = 1;
            this.messageTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.messageTextBox.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.messageTextBox.FocusedBorderColor = System.Drawing.Color.White;
            this.messageTextBox.FocusedForeColor = System.Drawing.Color.Silver;
            this.messageTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.messageTextBox.ForeColor = System.Drawing.Color.White;
            this.messageTextBox.Location = new System.Drawing.Point(12, 126);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.PasswordChar = '\0';
            this.messageTextBox.Radius = 5;
            this.messageTextBox.SelectedText = "";
            this.messageTextBox.Size = new System.Drawing.Size(362, 285);
            this.messageTextBox.TabIndex = 13;
            this.messageTextBox.Text = "Message";
            // 
            // opentxtButton
            // 
            this.opentxtButton.Animated = true;
            this.opentxtButton.AnimationHoverSpeed = 0.07F;
            this.opentxtButton.AnimationSpeed = 0.03F;
            this.opentxtButton.BackColor = System.Drawing.Color.Transparent;
            this.opentxtButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.opentxtButton.BorderColor = System.Drawing.Color.Silver;
            this.opentxtButton.BorderSize = 1;
            this.opentxtButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.opentxtButton.FocusedColor = System.Drawing.Color.Empty;
            this.opentxtButton.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold);
            this.opentxtButton.ForeColor = System.Drawing.Color.White;
            this.opentxtButton.Image = null;
            this.opentxtButton.ImageSize = new System.Drawing.Size(20, 20);
            this.opentxtButton.Location = new System.Drawing.Point(380, 233);
            this.opentxtButton.Name = "opentxtButton";
            this.opentxtButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.opentxtButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.opentxtButton.OnHoverForeColor = System.Drawing.Color.White;
            this.opentxtButton.OnHoverImage = null;
            this.opentxtButton.OnPressedColor = System.Drawing.Color.Black;
            this.opentxtButton.Radius = 5;
            this.opentxtButton.Size = new System.Drawing.Size(161, 33);
            this.opentxtButton.TabIndex = 7;
            this.opentxtButton.Text = "Open Text File";
            this.opentxtButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.opentxtButton.Click += new System.EventHandler(this.opentxtButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Animated = true;
            this.clearButton.AnimationHoverSpeed = 0.07F;
            this.clearButton.AnimationSpeed = 0.03F;
            this.clearButton.BackColor = System.Drawing.Color.Transparent;
            this.clearButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.clearButton.BorderColor = System.Drawing.Color.Silver;
            this.clearButton.BorderSize = 1;
            this.clearButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.clearButton.FocusedColor = System.Drawing.Color.Empty;
            this.clearButton.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold);
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.Image = null;
            this.clearButton.ImageSize = new System.Drawing.Size(20, 20);
            this.clearButton.Location = new System.Drawing.Point(380, 272);
            this.clearButton.Name = "clearButton";
            this.clearButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.clearButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.clearButton.OnHoverForeColor = System.Drawing.Color.White;
            this.clearButton.OnHoverImage = null;
            this.clearButton.OnPressedColor = System.Drawing.Color.Black;
            this.clearButton.Radius = 5;
            this.clearButton.Size = new System.Drawing.Size(161, 33);
            this.clearButton.TabIndex = 14;
            this.clearButton.Text = "Clear";
            this.clearButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // setforecolorButton
            // 
            this.setforecolorButton.Animated = true;
            this.setforecolorButton.AnimationHoverSpeed = 0.07F;
            this.setforecolorButton.AnimationSpeed = 0.03F;
            this.setforecolorButton.BackColor = System.Drawing.Color.Transparent;
            this.setforecolorButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.setforecolorButton.BorderColor = System.Drawing.Color.Silver;
            this.setforecolorButton.BorderSize = 1;
            this.setforecolorButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.setforecolorButton.FocusedColor = System.Drawing.Color.Empty;
            this.setforecolorButton.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold);
            this.setforecolorButton.ForeColor = System.Drawing.Color.White;
            this.setforecolorButton.Image = null;
            this.setforecolorButton.ImageSize = new System.Drawing.Size(20, 20);
            this.setforecolorButton.Location = new System.Drawing.Point(380, 311);
            this.setforecolorButton.Name = "setforecolorButton";
            this.setforecolorButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.setforecolorButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.setforecolorButton.OnHoverForeColor = System.Drawing.Color.White;
            this.setforecolorButton.OnHoverImage = null;
            this.setforecolorButton.OnPressedColor = System.Drawing.Color.Black;
            this.setforecolorButton.Radius = 5;
            this.setforecolorButton.Size = new System.Drawing.Size(161, 33);
            this.setforecolorButton.TabIndex = 15;
            this.setforecolorButton.Text = "Set Fore Color";
            this.setforecolorButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.setforecolorButton.Click += new System.EventHandler(this.setforecolorButton_Click);
            // 
            // delayLabel
            // 
            this.delayLabel.AutoSize = true;
            this.delayLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.delayLabel.ForeColor = System.Drawing.Color.White;
            this.delayLabel.Location = new System.Drawing.Point(12, 425);
            this.delayLabel.Name = "delayLabel";
            this.delayLabel.Size = new System.Drawing.Size(208, 25);
            this.delayLabel.TabIndex = 16;
            this.delayLabel.Text = "Delay (Milisecond):";
            // 
            // titlelabelDragControl
            // 
            this.titlelabelDragControl.TargetControl = this.titleLabel;
            // 
            // stopButton
            // 
            this.stopButton.Animated = true;
            this.stopButton.AnimationHoverSpeed = 0.07F;
            this.stopButton.AnimationSpeed = 0.03F;
            this.stopButton.BackColor = System.Drawing.Color.Transparent;
            this.stopButton.BaseColor = System.Drawing.Color.Red;
            this.stopButton.BorderColor = System.Drawing.Color.Silver;
            this.stopButton.BorderSize = 1;
            this.stopButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.stopButton.Enabled = false;
            this.stopButton.FocusedColor = System.Drawing.Color.Empty;
            this.stopButton.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold);
            this.stopButton.ForeColor = System.Drawing.Color.White;
            this.stopButton.Image = null;
            this.stopButton.ImageSize = new System.Drawing.Size(20, 20);
            this.stopButton.Location = new System.Drawing.Point(380, 408);
            this.stopButton.Name = "stopButton";
            this.stopButton.OnHoverBaseColor = System.Drawing.Color.OrangeRed;
            this.stopButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.stopButton.OnHoverForeColor = System.Drawing.Color.White;
            this.stopButton.OnHoverImage = null;
            this.stopButton.OnPressedColor = System.Drawing.Color.Black;
            this.stopButton.Radius = 10;
            this.stopButton.Size = new System.Drawing.Size(161, 46);
            this.stopButton.TabIndex = 18;
            this.stopButton.Text = "Stop";
            this.stopButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // spammerTimer
            // 
            this.spammerTimer.Interval = 1000;
            this.spammerTimer.Tick += new System.EventHandler(this.spammerTimer_Tick);
            // 
            // delayTextBox
            // 
            this.delayTextBox.BackColor = System.Drawing.Color.Transparent;
            this.delayTextBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.delayTextBox.BorderColor = System.Drawing.Color.Silver;
            this.delayTextBox.BorderSize = 1;
            this.delayTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.delayTextBox.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.delayTextBox.FocusedBorderColor = System.Drawing.Color.White;
            this.delayTextBox.FocusedForeColor = System.Drawing.Color.Silver;
            this.delayTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.delayTextBox.ForeColor = System.Drawing.Color.White;
            this.delayTextBox.Location = new System.Drawing.Point(226, 423);
            this.delayTextBox.MaxLength = 7;
            this.delayTextBox.Name = "delayTextBox";
            this.delayTextBox.PasswordChar = '\0';
            this.delayTextBox.Radius = 5;
            this.delayTextBox.SelectedText = "";
            this.delayTextBox.Size = new System.Drawing.Size(95, 30);
            this.delayTextBox.TabIndex = 19;
            this.delayTextBox.Text = "1000";
            this.delayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.delayTextBox.TextChanged += new System.EventHandler(this.delayTextBox_TextChanged);
            this.delayTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.delayTextBox_KeyPress);
            // 
            // spammerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(800, 465);
            this.Controls.Add(this.delayTextBox);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.delayLabel);
            this.Controls.Add(this.setforecolorButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.opentxtButton);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.webhookTextBox);
            this.Controls.Add(this.nicknameTextBox);
            this.Controls.Add(this.singleSettingsCheckBox);
            this.Controls.Add(this.webhookandnicknamePanel);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "spammerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spammer";
            this.Load += new System.EventHandler(this.spammerForm_Load);
            this.webhookandnicknamePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel titleLabel;
        private Guna.UI.WinForms.GunaElipse labelbgElipse;
        private System.Windows.Forms.ListBox webhookListBox;
        private Guna.UI.WinForms.GunaElipse webhooklstbxElipse;
        private Guna.UI.WinForms.GunaButton reloadwebhookButton;
        private Guna.UI.WinForms.GunaButton reloadnicknamesButton;
        private System.Windows.Forms.ListBox nicknameListBox;
        private Guna.UI.WinForms.GunaElipse formElipse;
        private Guna.UI.WinForms.GunaElipse nicknamelstbxElipse;
        private Guna.UI.WinForms.GunaCheckBox singleSettingsCheckBox;
        private Guna.UI.WinForms.GunaPanel webhookandnicknamePanel;
        private Guna.UI.WinForms.GunaTextBox nicknameTextBox;
        private Guna.UI.WinForms.GunaTextBox webhookTextBox;
        private Guna.UI.WinForms.GunaButton startButton;
        private Guna.UI.WinForms.GunaTextBox messageTextBox;
        private Guna.UI.WinForms.GunaButton opentxtButton;
        private Guna.UI.WinForms.GunaButton clearButton;
        private Guna.UI.WinForms.GunaButton setforecolorButton;
        private Guna.UI.WinForms.GunaLabel delayLabel;
        private Guna.UI.WinForms.GunaDragControl titlelabelDragControl;
        private Guna.UI.WinForms.GunaButton stopButton;
        private System.Windows.Forms.Timer spammerTimer;
        private Guna.UI.WinForms.GunaTextBox delayTextBox;
    }
}