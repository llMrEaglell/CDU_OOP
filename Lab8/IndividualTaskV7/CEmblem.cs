using System.Drawing;
using System.Windows.Forms;

namespace IndividualTaskV7
{
    public class CEmblem
    {
        private readonly Pen pen = new(Color.Red, 1f);

        public CEmblem(int x, int y, int size, string name, Color color)
        {
            this.X = x;
            this.Y = y;
            this.Size = size;
            this.Name = name;
            this.Color = color;
            CurrentColor = color;
        }

        private Color Color { get; }
        public Color CurrentColor { get; set; }
        public int Size { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        private string Name { get; }

        public override string ToString()
        {
            return Name;
        }

        public void Draw(PictureBox pictureBox)
        {
            pen.Color = CurrentColor;
            using (var g = Graphics.FromImage(pictureBox.Image))
            {
                g.DrawEllipse(pen, X, Y, Size, Size);

                var firstTriangle = new Point[3];
                firstTriangle[0].X = X + Size / 2;
                firstTriangle[0].Y = Y + Size;
                firstTriangle[1].X = X + Size / 15;
                firstTriangle[1].Y = Y + Size / 4;
                firstTriangle[2].X = X + Size - Size / 15;
                firstTriangle[2].Y = Y + Size / 4;

                var secondTriangle = new Point[3];
                secondTriangle[0].X = X + Size / 2;
                secondTriangle[0].Y = Y;
                secondTriangle[1].X = X + Size / 15;
                secondTriangle[1].Y = Y + Size / 4 * 3;
                secondTriangle[2].X = X + Size - Size / 15;
                secondTriangle[2].Y = Y + Size / 4 * 3;
                g.DrawPolygon(pen, secondTriangle);

                g.DrawPolygon(pen, firstTriangle);
                pictureBox.Refresh();
            }
        }

        public void MoveRight()
        {
            if (X != 737 - Size)
            {
                X++;
            }
        }

        public void MoveLeft()
        {
            if (X != 0)
            {
                X--;
            }
        }

        public void MoveUp()
        {
            if (Y != 0)
            {
                Y--;
            }
        }

        public void MoveDown()
        {
            if (Y != 560 - Size)
            {
                Y++;
            }
        }

        public void EndUp()
        {
            Y = 0;
        }

        public void EndDown()
        {
            Y = 560 - Size;
        }

        public void EndLeft()
        {
            X = 0;
        }

        public void EndRight()
        {
            X = 737 - Size;
        }

        public void Enlarge()
        {
            Size++;
        }

        public void Reduce()
        {
            if (Size > 0)
            {
                Size--;
            }
        }

        public void Hide()
        {
            CurrentColor = Color.White;
        }

        public void Show()
        {
            CurrentColor = Color;
        }
    }
}