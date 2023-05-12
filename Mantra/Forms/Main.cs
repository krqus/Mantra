using Mantra.Control;
using System;
using System.Windows.Forms;

namespace Mantra
{
    public partial class Upload : Form
    {
        delweb deletewebhook = new delweb();
        sendweb sendwebhook = new sendweb();
        chatting chatwebhook = new chatting();

        public Upload()
        {
            InitializeComponent();
        }

        private void addUserControl(UserControl uc)
        {
            guna2Panel1.Controls.Remove(uc);
            uc.BringToFront();
            guna2Panel1.Controls.Add(uc);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            
            addUserControl(deletewebhook);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            
            addUserControl(sendwebhook);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            addUserControl(chatwebhook);
        }
    }
}
