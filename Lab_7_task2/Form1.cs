using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2_New_Task2
{
    public delegate void Opacity(double x);
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeOpacity();
        }

        private void ChangeOpacity()
        {
            if (Opacity != 1)
            {
                Opacity = 1;
            }
            else
            {
                Opacity = 0.25;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangeBGColor();
        }

        private static void ChangeBGColor()
        {
            if (ActiveForm.BackColor == DefaultBackColor)
            {
                ActiveForm.BackColor = Color.Chartreuse;
            }
            else
            {
                ActiveForm.BackColor = DefaultBackColor;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Hello World!", 
                "Повідомлення", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Я супермегакнопка,\n i цього мене не позбавиш!", 
                "Повідомлення", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
            
            if (checkBox1.Checked)
            {
                ChangeOpacity();
            }
            
            if (checkBox2.Checked)
            {
                ChangeBGColor();
            }
            
            if (checkBox3.Checked)
            {
                MessageBox.Show(
                    "Hello World!", 
                    "Повідомлення", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
        }
    }
}