using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordWebhookSpammer
{
    public partial class emergencyPull : Form
    {
        public emergencyPull()
        {
            InitializeComponent();
        }

        private void emergencyButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
