namespace DiscordWebhookSpammer
{
    partial class emergencyPull
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(emergencyPull));
            this.titleLabel = new Guna.UI.WinForms.GunaLabel();
            this.labelbgElipse = new Guna.UI.WinForms.GunaElipse(this.components);
            this.formElipse = new Guna.UI.WinForms.GunaElipse(this.components);
            this.titlelabelDragControl = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.emergencyButton = new Guna.UI.WinForms.GunaImageButton();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.titleLabel.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.Silver;
            this.titleLabel.Location = new System.Drawing.Point(11, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(222, 110);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Emergency Pull If this doesnt works (ALT + F4)";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelbgElipse
            // 
            this.labelbgElipse.Radius = 10;
            this.labelbgElipse.TargetControl = this.titleLabel;
            // 
            // formElipse
            // 
            this.formElipse.Radius = 5;
            this.formElipse.TargetControl = this;
            // 
            // titlelabelDragControl
            // 
            this.titlelabelDragControl.TargetControl = this.titleLabel;
            // 
            // emergencyButton
            // 
            this.emergencyButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.emergencyButton.Image = global::DiscordWebhookSpammer.Properties.Resources.icons8_fire_alarm_box_127px_2;
            this.emergencyButton.ImageSize = new System.Drawing.Size(127, 127);
            this.emergencyButton.Location = new System.Drawing.Point(54, 122);
            this.emergencyButton.Name = "emergencyButton";
            this.emergencyButton.OnHoverImage = null;
            this.emergencyButton.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.emergencyButton.Size = new System.Drawing.Size(128, 128);
            this.emergencyButton.TabIndex = 4;
            this.emergencyButton.Click += new System.EventHandler(this.emergencyButton_Click);
            // 
            // emergencyPull
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(245, 300);
            this.Controls.Add(this.emergencyButton);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "emergencyPull";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmergencyPull";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel titleLabel;
        private Guna.UI.WinForms.GunaElipse labelbgElipse;
        private Guna.UI.WinForms.GunaElipse formElipse;
        private Guna.UI.WinForms.GunaDragControl titlelabelDragControl;
        private Guna.UI.WinForms.GunaImageButton emergencyButton;
    }
}