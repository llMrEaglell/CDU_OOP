using System;


namespace Lab_3
{
    class TCylinder : TCircle
    {
        private double _height;

        public TCylinder() : base()
        {
            _height = 0;
        }

        public TCylinder(double height)
        {
            _height = height;
        }

        public TCylinder(double radius, double height) : base(radius)
        {
            _height = height;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nHeight:{this._height}";
        }

        public TCylinder(TCircle circle, double height) : base(circle)
        {
            _height = height;
        }

        public double GetVolume() => Math.PI * Math.Pow(base.Radius, 2) * _height;
    }
}