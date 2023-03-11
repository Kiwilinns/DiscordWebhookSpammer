namespace DiscordWebhookSpammer
{
    partial class mainForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.startButton = new Guna.UI.WinForms.GunaButton();
            this.formElipse = new Guna.UI.WinForms.GunaElipse(this.components);
            this.titleLabel = new Guna.UI.WinForms.GunaLabel();
            this.titlelabelDragControl = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Animated = true;
            this.startButton.AnimationHoverSpeed = 0.07F;
            this.startButton.AnimationSpeed = 0.03F;
            this.startButton.BackColor = System.Drawing.Color.Transparent;
            this.startButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.startButton.BorderColor = System.Drawing.Color.Silver;
            this.startButton.BorderSize = 1;
            this.startButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.startButton.FocusedColor = System.Drawing.Color.Empty;
            this.startButton.Font = new System.Drawing.Font("Century Gothic", 19.75F, System.Drawing.FontStyle.Bold);
            this.startButton.ForeColor = System.Drawing.Color.White;
            this.startButton.Image = null;
            this.startButton.ImageSize = new System.Drawing.Size(20, 20);
            this.startButton.Location = new System.Drawing.Point(12, 137);
            this.startButton.Name = "startButton";
            this.startButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.startButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.startButton.OnHoverForeColor = System.Drawing.Color.White;
            this.startButton.OnHoverImage = null;
            this.startButton.OnPressedColor = System.Drawing.Color.Black;
            this.startButton.Radius = 10;
            this.startButton.Size = new System.Drawing.Size(476, 53);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // formElipse
            // 
            this.formElipse.Radius = 5;
            this.formElipse.TargetControl = this;
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Century Gothic", 32F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.Silver;
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(476, 123);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "DiscordWebhook\r\nSpammer";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titlelabelDragControl
            // 
            this.titlelabelDragControl.TargetControl = this.titleLabel;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(500, 200);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.startButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DiscordWebhookSpammer";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaButton startButton;
        private Guna.UI.WinForms.GunaElipse formElipse;
        private Guna.UI.WinForms.GunaLabel titleLabel;
        private Guna.UI.WinForms.GunaDragControl titlelabelDragControl;
    }
}

