using System;
using System.Drawing;
using System.Windows.Forms;

namespace IndividualTaskV7
{
    public partial class Form1 : Form
    {
        int count = 0;
        Random r = new Random();

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        private void MoveTopMax_Click(object sender, EventArgs e)
        {
            if (isSelected())
            {
                CEmblem figure = (CEmblem) comboBox1.SelectedItem;
                if (figure.CurrentColor == Color.White)
                {
                    return;
                }

                figure.Hide();
                figure.Draw(pictureBox1);
                figure.EndUp();
                figure.Show();
                figure.Draw(pictureBox1);
                MoveTopMax.Enabled = false;
                MoveTop.Enabled = false;
                MoveDownMax.Enabled = true;
                MoveDown.Enabled = true;
            }
        }

        private void UpSize_Click(object sender, EventArgs e)
        {
            if (isSelected())
            {
                CEmblem figure = (CEmblem) comboBox1.SelectedItem;
                if (figure.CurrentColor == Color.White)
                {
                    return;
                }

                DownSize.Enabled = true;
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
            int randSize = r.Next(40, 200);
            int rand = r.Next(0, 737 - randSize);
            int rand2 = r.Next(0, 560 - randSize);

            CEmblem figure = new CEmblem(rand, rand2, randSize, "Figure " + count, Color.Red);
            figure.Show();
            figure.Draw(pictureBox1);
            comboBox1.Items.Add(figure);
            comboBox1.SelectedItem = figure;
        }

        private void HideObjButton_Click(object sender, EventArgs e)
        {
            if (isSelected())
            {
                CEmblem figure = (CEmblem) comboBox1.SelectedItem;
                figure.Hide();
                figure.Draw(pictureBox1);
            }
        }

        private void ShowObjButton_Click(object sender, EventArgs e)
        {
            if (isSelected())
            {
                CEmblem figure = (CEmblem) comboBox1.SelectedItem;
                figure.Show();
                figure.Draw(pictureBox1);
            }
        }

        private void DownSize_Click(object sender, EventArgs e)
        {
            if (isSelected())
            {
                CEmblem figure = (CEmblem) comboBox1.SelectedItem;
                if (figure.CurrentColor == Color.White)
                {
                    return;
                }

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
                CEmblem figure = (CEmblem) comboBox1.SelectedItem;
                if (figure.CurrentColor == Color.White)
                {
                    return;
                }

                figure.Hide();
                figure.Draw(pictureBox1);
                figure.MoveUp();
                figure.Show();
                figure.Draw(pictureBox1);
                MoveDownMax.Enabled = true;
                MoveDown.Enabled = true;
            }
        }

        private void MoveLeft_Click(object sender, EventArgs e)
        {
            if (isSelected())
            {
                CEmblem figure = (CEmblem) comboBox1.SelectedItem;
                if (figure.CurrentColor == Color.White)
                {
                    return;
                }

                figure.Hide();
                figure.Draw(pictureBox1);
                figure.MoveLeft();
                figure.Show();
                figure.Draw(pictureBox1);
                MoveRight.Enabled = true;
                MoveRighMax.Enabled = true;
            }
        }

        private void MoveRight_Click(object sender, EventArgs e)
        {
            if (isSelected())
            {
                CEmblem figure = (CEmblem) comboBox1.SelectedItem;
                if (figure.CurrentColor == Color.White)
                {
                    return;
                }

                figure.Hide();
                figure.Draw(pictureBox1);
                figure.MoveRight();
                figure.Show();
                figure.Draw(pictureBox1);
                MoveLeftMax.Enabled = true;
                MoveLeft.Enabled = true;
            }
        }

        private void MoveDown_Click(object sender, EventArgs e)
        {
            if (isSelected())
            {
                CEmblem figure = (CEmblem) comboBox1.SelectedItem;
                if (figure.CurrentColor == Color.White)
                {
                    return;
                }

                figure.Hide();
                figure.Draw(pictureBox1);
                figure.MoveDown();
                figure.Show();
                figure.Draw(pictureBox1);
                MoveTopMax.Enabled = true;
                MoveTop.Enabled = true;
            }
        }

        private void MoveLeftMax_Click(object sender, EventArgs e)
        {
            if (isSelected())
            {
                CEmblem figure = (CEmblem) comboBox1.SelectedItem;
                if (figure.CurrentColor == Color.White)
                {
                    return;
                }

                figure.Hide();
                figure.Draw(pictureBox1);
                figure.EndLeft();
                figure.Show();
                figure.Draw(pictureBox1);
                MoveLeftMax.Enabled = false;
                MoveLeft.Enabled = false;
                MoveRight.Enabled = true;
                MoveRighMax.Enabled = true;
            }
        }

        private void MoveRighMax_Click(object sender, EventArgs e)
        {
            if (isSelected())
            {
                CEmblem figure = (CEmblem) comboBox1.SelectedItem;
                if (figure.CurrentColor == Color.White)
                {
                    return;
                }

                figure.Hide();
                figure.Draw(pictureBox1);
                figure.EndRight();
                figure.Show();
                figure.Draw(pictureBox1);
                MoveRighMax.Enabled = false;
                MoveRight.Enabled = false;
                MoveLeftMax.Enabled = true;
                MoveLeft.Enabled = true;
            }
        }

        private void MoveDownMax_Click(object sender, EventArgs e)
        {
            if (isSelected())
            {
                CEmblem figure = (CEmblem) comboBox1.SelectedItem;
                if (figure.CurrentColor == Color.White)
                {
                    return;
                }

                figure.Hide();
                figure.Draw(pictureBox1);
                figure.EndDown();
                figure.Show();
                figure.Draw(pictureBox1);
                MoveDownMax.Enabled = false;
                MoveDown.Enabled = false;
                MoveTopMax.Enabled = true;
                MoveTop.Enabled = true;
            }
        }

        private bool isSelected()
        {
            bool check = string.IsNullOrEmpty(comboBox1.Text);
            if (check)
                MessageBox.Show("No item selected!");
            return !check;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MoveDown.Enabled = true;
            MoveDownMax.Enabled = true;
            MoveTop.Enabled = true;
            MoveTopMax.Enabled = true;
            MoveLeft.Enabled = true;
            MoveLeftMax.Enabled = true;
            MoveRight.Enabled = true;
            MoveRighMax.Enabled = true;
        }
    }
}