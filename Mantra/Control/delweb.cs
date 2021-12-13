using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mantra
{
    public partial class delweb : UserControl
    {
        public delweb()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                var request = WebRequest.Create(guna2TextBox1.Text);
                request.Method = "DELETE";
                var response = (HttpWebResponse)request.GetResponse();
                label1.Text = "Success!";
                label1.ForeColor = Color.LightGreen;
                label1.Visible = true;
            }

            catch (Exception ex)
            {
                label1.Text = "Failed!";
                label1.ForeColor = Color.LightGreen;
                label1.Visible = false;
                MessageBox.Show(ex.Message);


            }
        }
}
}
