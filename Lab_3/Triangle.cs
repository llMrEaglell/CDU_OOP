using System;


namespace Lab_3
{
    public class Triangle
    {
        private Point pointA;
        private Point pointB;
        private Point pointC;

        public double a
        {
            get => pointA + pointB;
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException(nameof(value));
                a = value;
            }
        }

        public double b
        {
            get => pointB + pointC;
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException(nameof(value));
                b = value;
            }
        }

        public double c
        {
            get => pointC + pointA;
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException(nameof(value));
                c = value;
            }
        }

        public Triangle(Point pointA, Point pointB, Point pointC)
        {
            this.pointA = pointA;
            this.pointB = pointB;
            this.pointC = pointC;
        }

        public double perimeter()
        {
            return a + b + c;
        }

        public double sqare()
        {
            
            double perimetr_2 = perimeter() / 2;
            return Math.Round(Math.Sqrt(perimetr_2 * (perimetr_2 - a) * (perimetr_2 - b) * (perimetr_2 - c)),2);
        }
    }
}