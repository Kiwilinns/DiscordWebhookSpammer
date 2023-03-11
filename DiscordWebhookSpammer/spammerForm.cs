using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Net.WebRequestMethods;
using Discord.Webhook;
using System.Drawing.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DiscordWebhookSpammer
{
    public partial class spammerForm : Form
    {
        public spammerForm()
        {
            InitializeComponent();
        }

        string _webhookfolderPath = @".\webhooks";

        string[] _webhookFiles;

        DiscordWebhookClient _dwc;

        void _reloadWebhookList()
        {
            _webhookFiles = Directory.GetFiles(_webhookfolderPath);

            foreach (string file in _webhookFiles)
            {
                webhookListBox.Items.Add(Path.GetFileName(file));
            }
        }


        string _nicknamefolderPath = @".\nicknames";

        string[] _nicknameFiles;

        void _reloadNickNameList()
        {
            _nicknameFiles = Directory.GetFiles(_nicknamefolderPath);

            foreach (string file in _nicknameFiles)
            {
                nicknameListBox.Items.Add(Path.GetFileName(file));
            }
        }

        private void spammerForm_Load(object sender, EventArgs e)
        {
            _reloadWebhookList();
            _reloadNickNameList();
        }


        private void reloadwebhookButton_Click(object sender, EventArgs e)
        {
            _reloadWebhookList();
        }

        private void reloadnicknamesButton_Click(object sender, EventArgs e)
        {
            _reloadNickNameList();
        }

        private void singleSettingsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(singleSettingsCheckBox.Checked)
            {
                webhookandnicknamePanel.Enabled = false;
                webhookTextBox.Enabled = true;
                nicknameTextBox.Enabled = true;
            }
            if (!singleSettingsCheckBox.Checked)
            {
                webhookandnicknamePanel.Enabled = true;
                webhookTextBox.Enabled = false;
                nicknameTextBox.Enabled = false;
            }
        }


        private void setforecolorButton_Click(object sender, EventArgs e)
        {
            ColorDialog _cd = new ColorDialog();
            if(_cd.ShowDialog()==DialogResult.OK)
            {
                messageTextBox.ForeColor = _cd.Color;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            messageTextBox.Text = "";
        }

        private void opentxtButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog _opf = new OpenFileDialog();
            
            _opf.Filter = "Text File (*.txt)|*.txt";

            if (_opf.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamReader sr = new StreamReader(_opf.FileName))
                    {
                        messageTextBox.Text = sr.ReadToEnd();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dosya yüklenemedi: " + ex.Message);
                }
            }
        }

        private void delayNumeric_ValueChanged(object sender, EventArgs e)
        {
            spammerTimer.Interval = Convert.ToInt32(delayTextBox.Text);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            spammerTimer.Start();
            startButton.Enabled = false;
            stopButton.Enabled = true;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            spammerTimer.Stop();
            startButton.Enabled = true;
            stopButton.Enabled = false;
        }

        private void spammerTimer_Tick(object sender, EventArgs e)
        {
            if (singleSettingsCheckBox.Checked)
            {
                string _selectedWebhook = webhookTextBox.Text;
                string _selectedNickName = nicknameTextBox.Text;
                _dwc = new DiscordWebhookClient(_selectedWebhook);
                _dwc.SendMessageAsync(messageTextBox.Text, username: _selectedNickName);
            }
            else
            {
                if (webhookListBox.SelectedIndex != -1 && nicknameListBox.SelectedIndex != -1)
                {
                    Random rnd = new Random();
                    string _selectedWebhook;
                    string _selectedNickname;
                    string[] linewebhook = System.IO.File.ReadAllLines($@"./webhooks/{webhookListBox.Text}");
                    _selectedWebhook = linewebhook[rnd.Next(0, linewebhook.Length)];
                    string[] linenick = System.IO.File.ReadAllLines($@"./nicknames/{nicknameListBox.Text}");
                    _selectedNickname = linenick[rnd.Next(0, linenick.Length)];
                    _dwc = new DiscordWebhookClient(_selectedWebhook);
                    _dwc.SendMessageAsync(messageTextBox.Text, username: _selectedNickname);
                }
            }
        }

        private void delayTextBox_TextChanged(object sender, EventArgs e)
        {
            spammerTimer.Interval = Convert.ToInt32(delayTextBox.Text);
        }

        private void delayTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '\u007f')
            {
                e.Handled = true;
            }
        }
    }
}