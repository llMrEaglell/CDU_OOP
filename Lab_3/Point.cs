using System;
using System.Runtime.CompilerServices;

namespace Lab_3
{
    public class Point
    {
        private int X
        {
            get => X;
            set => X = value;
        }

        private int Y
        {
            get => Y;
            set => Y = value;
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