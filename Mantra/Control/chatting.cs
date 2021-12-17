using DiscordMessenger;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mantra.Control
{
    public partial class chatting : UserControl
    {
        public chatting()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                new DiscordMessage()
                    .SetUsername(guna2TextBox3.Text)
                    .SetAvatar(guna2TextBox1.Text)
                    .SetContent(guna2TextBox4.Text)
                    .SendMessage(guna2TextBox2.Text);
                label1.Visible = true;
                label1.ForeColor = Color.Lime;
                label1.Text = "Success";
            }
            catch
            {
                label1.Visible = true;
                label1.ForeColor = Color.Red;
                label1.Text = "Failed";
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            guna2CirclePictureBox1.LoadAsync(guna2TextBox1.Text);
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {
            label3.Text = guna2TextBox3.Text;
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {
            label4.Text = guna2TextBox4.Text;
        }
    }
}
