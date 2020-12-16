namespace Lab5
{
    public class Complex : IMyNumber<Complex>
    {
        private double Im { get; set; }

        private double Re { get; set; }


        public Complex(double re,double im)
        {
            Im = im;
            Re = re;
        }

        public Complex Add(Complex obj) => new Complex(this.Re + obj.Re, this.Im + obj.Im);

        public Complex Substract(Complex obj) => throw new System.NotImplementedException();

        public Complex Multiply(Complex obj) => new Complex(Re * obj.Re, Im * obj.Im);

        public Complex Devide(Complex obj) => throw new System.NotImplementedException();

        public override string ToString() => $"{Re}+{Im}i";
    }
}