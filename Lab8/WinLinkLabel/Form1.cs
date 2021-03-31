using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WinLinkLabel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult aResult;
            Form2 aForm = new Form2();
            aResult = aForm.ShowDialog();
            if (aResult == DialogResult.OK)
            {
                MessageBox.Show("Your name іs " + aForm.textBox1.Text + " " + aForm.textBox2.Text);
                MessageBox.Show("Your address іs " + aForm.textBox3.Text);

                MessageBox.Show("Your phone number іs " + aForm.maskedTextBox1.Text);
            }

            linkLabel1.LinkVisited = true;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked." + ex.Message);
            }
        }

        private void VisitLink()
        {
            Process myProcess = new Process();
            myProcess.StartInfo.UseShellExecute = true;
            myProcess.StartInfo.FileName = "https://github.com/llMrEaglell";
            myProcess.Start();
        }
    }
}