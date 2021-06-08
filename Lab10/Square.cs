using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Square : Figure
    {
        private double Side { get; }

        public Square()
        {
        }

        public Square(int sideLength)
        {
            this.Side = sideLength;
        }

        public Square(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Square(int x, int y, double side)
        {
            this.Side = side;
            this.x = x;
            this.y = y;
        }

        public override void DrawBlack(PictureBox p)
        {
            using (var g = Graphics.FromImage(p.Image))
            {
                g.DrawRectangle(Pens.Black, x, y, (int) Side, (int) Side);
            }
        }

        public override void HideDrawingBackGround(PictureBox p)
        {
            using (var g = Graphics.FromImage(p.Image))
            {
                g.DrawRectangle(Pens.White, x, y, (int) Side, (int) Side);
            }
        }
    }
}