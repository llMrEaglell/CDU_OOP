using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba1Task4
{
    public partial class Form1 : Form
    {
        private int _count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _count++;
            Label label = new Label();
            label.Text = $"Label:{_count}";
            label.Location = new Point(10, 50 * _count);
            label.Font = new Font("Arial", 10, FontStyle.Bold);
            this.Controls.Add(label);
            label.MouseHover += (o, args) => label1.Text = $"U select label:{_count}";
        }
    }
}