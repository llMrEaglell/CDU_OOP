using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using static System.Convert;

namespace Lab10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Bitmap b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = b;
            numericUpDown1.Value = 100;
        }

        private void circle_Click(object sender, EventArgs e)
        {
            Figure figure = new Circle(2, 80, 56);
            DrawFigure(GenerateMove(figure));
        }

        private void square_Click(object sender, EventArgs e)
        {
            Figure figure = new Square(56);
            DrawFigure(GenerateMove(figure));
        }

        private void rhomb_Click(object sender, EventArgs e)
        {
            Figure figure = new Rhomb(10, 180, 50, 50);
            DrawFigure(GenerateMove(figure));
        }

        private static async void DrawFigure(Action action)
        {
            await Task.Run(action);
        }

        private Action GenerateMove(Figure figure)
        {
            return () =>
            {
                while (true)
                {
                    figure.MoveRight(pictureBox1);
                    Thread.Sleep(ToInt32(numericUpDown1.Value));
                    Invoke(new MethodInvoker(() => pictureBox1.Refresh()));
                    if (figure.x == pictureBox1.Size.Width)
                        break;
                }
            };
        }
    }
}