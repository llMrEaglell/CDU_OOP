using System;
using System.Windows.Forms;

namespace WіnQuestіon_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnyes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mи й не сумнівалися, що Ви так думаєте!");
        }

        private void btnno_MouseMove(object sender, MouseEventArgs e)
        {
            btnno.Top -= e.Y;
            btnno.Left += e.X;
            if (btnno.Top < -10 || btnno.Top > 100) btnno.Top = 60;
            if (btnno.Left < -80 || btnno.Left > 250) btnno.Left = 120;
        }
    }
}