using System;
using static System.Math;

namespace Lab_1
{
    class TTriangle
    {
        protected double _hypotenuse;
        protected double _opposite;
        protected double _adjacent;

        public TTriangle(double hypotenuse, double opposite, double adjacent)
        {
            if (opposite + adjacent > hypotenuse && adjacent + hypotenuse > opposite &&
                hypotenuse + opposite > adjacent && opposite > 0 && adjacent > 0 && hypotenuse > 0)
            {
                this.hypotenuse = hypotenuse;
                this.opposite = opposite;
                this.adjacent = adjacent;
            }
            else throw new Exception("Triangle does not exist ");
        }

        public double hypotenuse
        {
            get { return _hypotenuse; }
            set
            {
                if ((opposite + adjacent > value && adjacent + value > opposite && value + opposite > adjacent &&
                     opposite > 0 && adjacent > 0 && value > 0) || hypotenuse == 0 || opposite == 0 ||
                    adjacent == 0) _hypotenuse = value;
                else throw new Exception("Triangle does not exist ");
            }
        }

        public double opposite
        {
            get { return _opposite; }
            set
            {
                if ((value + adjacent > hypotenuse && adjacent + hypotenuse > value && hypotenuse + value > adjacent &&
                     value > 0 && adjacent > 0 && hypotenuse > 0) || hypotenuse == 0 || opposite == 0 ||
                    adjacent == 0) _opposite = value;
                else throw new Exception("Triangle does not exist ");
            }
        }

        public double adjacent
        {
            get { return _adjacent; }
            set
            {
                if ((opposite + value > hypotenuse && value + hypotenuse > opposite && hypotenuse + opposite > value &&
                     opposite > 0 && value > 0 && hypotenuse > 0) || hypotenuse == 0 || opposite == 0 ||
                    adjacent == 0) _adjacent = value;
                else throw new Exception("Triangle does not exist ");
            }
        }

        public double perimetr()
        {
            return hypotenuse + opposite + adjacent;
        }

        public double square()
        {
            double perimetr_2 = perimetr() / 2;
            return Sqrt(perimetr_2 * (perimetr_2 - opposite) * (perimetr_2 - adjacent) * (perimetr_2 - hypotenuse));
        }

        public override string ToString()
        {
            return "Hypotenuse:" + hypotenuse + "\nOpposite:" + opposite + "\nAdjacent:" + adjacent + "\n";
        }

    }
}