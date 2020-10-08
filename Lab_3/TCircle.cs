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
                else this.Radius=value;
            }
        }

        public TCircle()
        {
            this.Radius = 0;
        }
        public TCircle(double radius)
        {
            this.Radius = radius;
        }
        public TCircle(TCircle circle)
        {
            this.Radius = circle.Radius;
        }

        public override string ToString()
        {
            return string.Format("Radius:{0}",this.Radius);
        }
    }
}