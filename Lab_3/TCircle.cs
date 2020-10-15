using System;

namespace Lab_3
{
    public class TCircle
    {
        private double _radius;

        public double Radius
        {
            get => _radius;
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException(nameof(value));
                else this._radius = value;
            }
        }

        public TCircle() => this.Radius = 0;
        public TCircle(double radius) => this.Radius = radius;
        public TCircle(TCircle circle) => this.Radius = circle.Radius;

        public double GetLength() => 2 * Math.PI * Radius;

        public double GetSquare() => Math.PI * Math.Pow(Radius, 2);

        public override string ToString() => $"Radius:{this.Radius}";
        public static bool operator >(TCircle circle1, TCircle circle2) => circle1.Radius > circle2.Radius;
        public static bool operator <(TCircle circle1, TCircle circle2) => circle1.Radius < circle2.Radius;
        public static bool operator ==(TCircle circle1, TCircle circle2) => circle1.Radius == circle2.Radius;
        public static bool operator !=(TCircle circle1, TCircle circle2) => circle1.Radius != circle2.Radius;

        public static TCircle operator +(TCircle circle1, TCircle circle2) =>
            new TCircle(circle1.Radius + circle2.Radius);

        public static TCircle operator -(TCircle circle1, TCircle circle2) =>
            new TCircle(Math.Abs(circle1.Radius - circle2.Radius));

        public static TCircle operator *(TCircle circle1, double number) =>
            new TCircle(circle1.Radius * number);

        public static TCircle operator *(double number, TCircle circle1) =>
            new TCircle(circle1.Radius * number);

        public double GetSector(double angle) => Math.PI * Math.Pow(this.Radius, 2) * (angle / 360);


        public override bool Equals(object? obj)
        {
            if ((obj == null) || this.GetType() != obj.GetType()) return false;
            TCircle temp = (TCircle) obj;
            return Radius == temp.Radius;
        }

        public override int GetHashCode()
        {
            return Radius.GetHashCode();
        }
    }
}