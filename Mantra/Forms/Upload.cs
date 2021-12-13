using Mantra.Control;
using System;
using System.Windows.Forms;

namespace Mantra
{
    public partial class Upload : Form
    {

        public Upload()
        {
            InitializeComponent();
        }

        private void addUserControl(UserControl uc)
        {
            guna2Panel1.Controls.Clear();
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
            delweb uC_ = new delweb();
            addUserControl(uC_);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            sendweb uC_ = new sendweb();
            addUserControl(uC_);
        }
    }
}
