using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.MessageBox;

namespace RegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                var lbl = CrateLabel();
                groupBox1.Controls.Add(lbl);
                var txt = CreateTextBox();
                groupBox1.Controls.Add(txt);
                txt.KeyPress += textBox2_KeyPress;
            }
            else
            {
                groupBox1.Controls.Clear();
            }
        }

        private static TextBox CreateTextBox()
        {
            TextBox txt = new TextBox();
            txt.Location = new Point(96, 96);
            txt.Size = new Size(184, 20);
            txt.Name = "textboxx";
            txt.TabIndex = 1;
            txt.Text = "";
            return txt;
        }

        private static Label CrateLabel()
        {
            Label lbl = new Label();
            lbl.Location = new Point(16, 96);
            lbl.Size = new Size(35, 30);
            lbl.Name = "labelll";
            lbl.TabIndex = 2;
            lbl.Text = "PІN2";
            return lbl;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Поле Name не може містити цифри");
            }

            errorProvider1.SetError(textBox1, "Must be letter");
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Поле PІN не може містити букви");
            }
        }

        private void checkBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2.Text == "")
            {
                e.Cancel = false;
            }
            else
            {
                try
                {
                    double.Parse(textBox2.Text);
                    e.Cancel = false;
                }
                catch
                {
                    e.Cancel = true;
                    MessageBox.Show("Поле PІN не може містити букви");
                }
            }
        }
    }
}