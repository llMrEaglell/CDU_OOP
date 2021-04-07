using System;
using System.Drawing;
using System.Windows.Forms;

namespace IndividualTaskV7
{
    public partial class Form1 : Form
    {
        private int count;
        private readonly Random r = new();

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        private void MoveTopMax_Click(object sender, EventArgs e)
        {
            if (isSelected())
            {
                var figure = (CEmblem) comboBox1.SelectedItem;
                if (figure.CurrentColor == Color.White) return;
                figure.Hide();
                figure.Draw(pictureBox1);
                figure.EndUp();
                figure.Show();
                figure.Draw(pictureBox1);
            }
        }

        private void UpSize_Click(object sender, EventArgs e)
        {
            if (isSelected())
            {
                var figure = (CEmblem) comboBox1.SelectedItem;
                if (figure.CurrentColor == Color.White) return;
                if (figure.Size > 0) DownSize.Enabled = true;
                figure.Hide();
                figure.Draw(pictureBox1);
                figure.Enlarge();
                figure.Show();
                figure.Draw(pictureBox1);
            }
        }

        private void CreateNewObjButton_Click(object sender, EventArgs e)
        {
            count++;
            var randSize = r.Next(40, 200);
            var rand = r.Next(0, 553 - randSize);
            var rand2 = r.Next(0, 366 - randSize);

            var figure = new CEmblem(rand, rand2, randSize, "Figure " + count, Color.Red);
            figure.Show();
            figure.Draw(pictureBox1);
            comboBox1.Items.Add(figure);
        }

        private void HideObjButton_Click(object sender, EventArgs e)
        {
            if (isSelected())
            {
                var figure = (CEmblem) comboBox1.SelectedItem;
                figure.Hide();
                figure.Draw(pictureBox1);
            }
        }

        private void ShowObjButton_Click(object sender, EventArgs e)
        {
            if (isSelected())
            {
                var figure = (CEmblem) comboBox1.SelectedItem;
                figure.Show();
                figure.Draw(pictureBox1);
            }
        }

        private void DownSize_Click(object sender, EventArgs e)
        {
            if (isSelected())
            {
                var figure = (CEmblem) comboBox1.SelectedItem;
                if (figure.CurrentColor == Color.White) return;
                if (figure.Size > 0)
                {
                    figure.Hide();
                    figure.Draw(pictureBox1);
                    figure.Reduce();
                    figure.Show();
                    figure.Draw(pictureBox1);
                }
                else
                {
                    DownSize.Enabled = false;
                }
            }
        }


        private void MoveTop_Click(object sender, EventArgs e)
        {
            if (isSelected())
            {
                var figure = (CEmblem) comboBox1.SelectedItem;
                if (figure.CurrentColor == Color.White) return;
                figure.Hide();
                figure.Draw(pictureBox1);
                figure.MoveUp();
                figure.Show();
                figure.Draw(pictureBox1);
            }
        }

        private void MoveLeft_Click(object sender, EventArgs e)
        {
            if (isSelected())
            {
                var figure = (CEmblem) comboBox1.SelectedItem;
                if (figure.CurrentColor == Color.White) return;

                figure.Hide();
                figure.Draw(pictureBox1);
                figure.MoveLeft();
                figure.Show();
                figure.Draw(pictureBox1);
            }
        }

        private void MoveRight_Click(object sender, EventArgs e)
        {
            if (isSelected())
            {
                var figure = (CEmblem) comboBox1.SelectedItem;
                if (figure.CurrentColor == Color.White) return;

                figure.Hide();
                figure.Draw(pictureBox1);
                figure.MoveRight();
                figure.Show();
                figure.Draw(pictureBox1);
            }
        }

        private void MoveDown_Click(object sender, EventArgs e)
        {
            if (isSelected())
            {
                var figure = (CEmblem) comboBox1.SelectedItem;
                if (figure.CurrentColor == Color.White) return;

                figure.Hide();
                figure.Draw(pictureBox1);
                figure.MoveDown();
                figure.Show();
                figure.Draw(pictureBox1);
            }
        }

        private void MoveLeftMax_Click(object sender, EventArgs e)
        {
            if (isSelected())
            {
                var figure = (CEmblem) comboBox1.SelectedItem;
                if (figure.CurrentColor == Color.White) return;

                figure.Hide();
                figure.Draw(pictureBox1);
                figure.EndLeft();
                figure.Show();
                figure.Draw(pictureBox1);
            }
        }

        private void MoveRighMax_Click(object sender, EventArgs e)
        {
            if (isSelected())
            {
                var figure = (CEmblem) comboBox1.SelectedItem;
                if (figure.CurrentColor == Color.White) return;

                figure.Hide();
                figure.Draw(pictureBox1);
                figure.EndRight();
                figure.Show();
                figure.Draw(pictureBox1);
            }
        }

        private void MoveDownMax_Click(object sender, EventArgs e)
        {
            if (isSelected())
            {
                var figure = (CEmblem) comboBox1.SelectedItem;
                if (figure.CurrentColor == Color.White) return;

                figure.Hide();
                figure.Draw(pictureBox1);
                figure.EndDown();
                figure.Show();
                figure.Draw(pictureBox1);
            }
        }

        private bool isSelected()
        {
            bool check = string.IsNullOrEmpty(comboBox1.Text);
            if (check)
                MessageBox.Show("No item selected");
            return !check;
        }
    }
}