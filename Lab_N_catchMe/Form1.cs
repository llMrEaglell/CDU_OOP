using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using static System.Console;

namespace Lab_N_catchMe
{
    public partial class Form1 : Form
    {
        private static readonly Random rand = new Random();
        private Point oldPos;

        public Form1()
        {
            InitializeComponent();
        }

        private void BOOm(object sender, MouseEventArgs e)
        {
            Controls.Remove(button1);
            label1.Text += " WOW";
        }

        private void check(object sender, MouseEventArgs e)
        {
            Point mousePosition = MousePosition;
            if (oldPos != mousePosition)
            {
                WriteLine(mousePosition.ToString());
                int loc = Math.Abs(mousePosition.X - button1.Location.X);
                int loc2 = Math.Abs(mousePosition.Y - button1.Location.Y);
                WriteLine(loc);
                WriteLine(loc2);
                if (loc > 100 || loc2 > 100)
                {
                    button1.Location = new Point(rand.Next(816), rand.Next(489));
                    oldPos = mousePosition;
                }
            }
        }
    }
}