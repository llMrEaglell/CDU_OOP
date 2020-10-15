using System;


namespace Lab_3
{
    public class Point
    {
        private int _x;
        private int _y;

        public int X
        {
            get => _x;
            set => _x = value;
        }

        public int Y
        {
            get => _y;
            set => _y = value;
        }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static double operator +(Point point1, Point point2) =>
            Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));
    }
}