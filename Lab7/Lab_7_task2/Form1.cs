﻿using System;
using System.Drawing;
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
        }

        private static void helo()
        {
            MessageBox.Show(
                "Hello World!",
                "Повідомлення",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                button4.MouseClick += mouseChangeOpacity();
            else
                button4.MouseClick -= mouseChangeOpacity();
        }

        private MouseEventHandler mouseChangeOpacity()
        {
            return (sender1, eventArgs) => ChangeOpacity();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                button4.MouseClick += mouseChangeBGColor();
            else
                button4.MouseClick -= mouseChangeBGColor();
        }

        private static MouseEventHandler mouseChangeBGColor()
        {
            return (o, args) => ChangeBGColor();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
                button4.MouseClick += mouseHello();
            else
                button4.MouseClick -= mouseHello();
        }

        private static MouseEventHandler mouseHello()
        {
            return (o, args) => helo();
        }
    }
}