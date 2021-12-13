using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mantra.Control
{
    public partial class sendweb : UserControl
    {
        string file;
        public sendweb()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
                OpenFileDialog openDialog = new OpenFileDialog();
                openDialog.Title = "Select A File";
                openDialog.Filter = "All Files (*.*)|*.*" + "|" +
                                    "Image Files (*.png;*.jpg)|*.png;*.jpg" + "|" +
                                    "Text Files (*.txt)|*.txt";
                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    file = openDialog.FileName;
                }

                guna2TextBox1.Text = file;

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                string Webhook_link = guna2TextBox2.Text;



                using (HttpClient httpClient = new HttpClient())
                {
                    OpenFileDialog openDialog = new OpenFileDialog();
                    MultipartFormDataContent form = new MultipartFormDataContent();
                    var file_bytes = System.IO.File.ReadAllBytes(file);
                    form.Add(new ByteArrayContent(file_bytes, 0, file_bytes.Length), "Mantra", file);
                    httpClient.PostAsync(Webhook_link, form).Wait();
                    httpClient.Dispose();
                }
                label1.Text = "Success!";
                label1.ForeColor = Color.LightGreen;
                label1.Visible = true;
                guna2TextBox1.Text = file;
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
