using System;


namespace Lab_3
{
    class TCylinder : TCircle
    {
        private double _height;

        public double Height
        {
            get => _height;
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException(nameof(value));
                else this._height = value;
            }
        }

        public TCylinder() : base()
        {
            _height = 0;
        }

        public TCylinder(double height)
        {
            _height = height;
        }

        public TCylinder(double radius, double height) : base(radius) => this.Height = height;

        public override string ToString() => base.ToString() + $"\nHeight:{this.Height}";

        public TCylinder(TCircle circle, double height) : base(circle) => this.Height = height;

        public static bool operator >(TCylinder cylinder1, TCylinder cylinder2) => cylinder1.Volume() > cylinder2.Volume();
        public static bool operator <(TCylinder cylinder1, TCylinder cylinder2) => cylinder1.Volume() < cylinder2.Volume();
        public static bool operator ==(TCylinder cylinder1, TCylinder cylinder2) => cylinder1.Volume() == cylinder2.Volume();
        public static bool operator !=(TCylinder cylinder1, TCylinder cylinder2) => cylinder1.Volume() != cylinder2.Volume();

        public double Volume() => Math.PI * Math.Pow(Radius, 2) * Height;

        public double Square() => 2 * Math.PI * Radius * (Height * Radius);

        public override bool Equals(object? obj)
        {
            if ((obj == null) || this.GetType() != obj.GetType()) return false;
            TCylinder temp = (TCylinder)obj;
            return Volume() == temp.Volume();
        }

        public override int GetHashCode()
        {
            return Volume().GetHashCode();
        }
    }
}