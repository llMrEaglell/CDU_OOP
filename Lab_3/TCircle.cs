using System;

namespace Lab_3
{
    public class TCircle
    {
        private double Radius
        {
            get => Radius;
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException(nameof(value));
                else this.Radius = value;
            }
        }

        public TCircle() => this.Radius = 0;
        public TCircle(double radius) => this.Radius = radius;
        public TCircle(TCircle circle) => this.Radius = circle.Radius;

        public double GetLength() => 2 * Math.PI * Radius;

        public double GetSquare() => Math.PI * Math.Pow(Radius, 2);

        public override string ToString() => $"Radius:{this.Radius}";

        public static TCircle operator +(TCircle circle1, TCircle circle2) =>
            new TCircle(circle1.Radius + circle2.Radius);

        public static TCircle operator -(TCircle circle1, TCircle circle2) =>
            new TCircle(Math.Abs(circle1.Radius - circle2.Radius));

        public static TCircle operator *(TCircle circle1, double number) =>
            new TCircle(circle1.Radius * number);

        public static TCircle operator *(double number, TCircle circle1) =>
            new TCircle(circle1.Radius * number);


        public override bool Equals(object? obj)
        {
            //TODO change
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            //TODO change
            return base.GetHashCode();
        }
    }
}