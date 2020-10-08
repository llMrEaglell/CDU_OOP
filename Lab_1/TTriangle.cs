using System;
using static System.Math;

namespace Lab_1
{
    class TTriangle
    {
        protected double _hypotenuse;
        protected double _opposite;
        protected double _adjacent;

        public TTriangle()
        {
            this.hypotenuse = 3;
            this.opposite = 4;
            this.adjacent = 5;
        }

        public TTriangle(double hypotenuse, double opposite, double adjacent)
        {
            if (check(hypotenuse, opposite, adjacent))
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
                if (check(hypotenuse, opposite, adjacent) || hypotenuse == 0 || opposite == 0 ||
                    adjacent == 0) _hypotenuse = value;
                else throw new Exception("Triangle does not exist ");
            }
        }

        public double opposite
        {
            get { return _opposite; }
            set
            {
                if (check(hypotenuse, opposite, adjacent) || hypotenuse == 0 || opposite == 0 ||
                    adjacent == 0) _opposite = value;
                else throw new Exception("Triangle does not exist ");
            }
        }

        public double adjacent
        {
            get { return _adjacent; }
            set
            {
                if (check(hypotenuse, opposite, adjacent) || hypotenuse == 0 || opposite == 0 ||
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

        private bool check(double hypotenuse, double opposite, double adjacent)
        {
            return opposite + adjacent > hypotenuse && adjacent + hypotenuse > opposite &&
                   hypotenuse + opposite > adjacent && opposite > 0 && adjacent > 0 && hypotenuse > 0;
        }
    }
}