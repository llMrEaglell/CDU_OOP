using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_6_1_v13
{
    public partial class Form1 : Form
    {
        private Random _random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void Block(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }

        private void UnBlock(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
        }

        private void ChangeColorAndHideElement(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(_random.Next(256),
                _random.Next(256), _random.Next(256));
        }
    }
}