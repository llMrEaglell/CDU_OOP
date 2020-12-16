using System;
using System.Numerics;

namespace Lab5
{
    public class MyFrac : IMyNumber<MyFrac>
    {
        private readonly BigInteger denom;
        private readonly BigInteger nom;
        public MyFrac(BigInteger nom, BigInteger denom)
        {
            if (denom.Equals(BigInteger.Zero))
                throw new DivideByZeroException($"Division by zero, numerator = {nom} ,denominator = {denom}");
            Simplify(ref nom, ref denom);
            this.nom = nom;
            this.denom = denom;
        }

        public MyFrac Add(MyFrac that) => new MyFrac(this.nom * that.denom + that.nom * this.denom, this.denom * that.denom);

        public MyFrac Substract(MyFrac that) => new MyFrac((nom * that.denom) - (that.nom * denom), denom * that.denom);

        public MyFrac Multiply(MyFrac that) => new MyFrac(nom * that.nom, denom * that.denom);

        public MyFrac Devide(MyFrac that) => new MyFrac(nom * that.denom, denom * that.nom);

        public override string ToString() => $"{nom}/{denom}";

        private void Simplify(ref BigInteger nom, ref BigInteger denom)
        {
            BigInteger gcd = BigInteger.GreatestCommonDivisor(nom, denom);
            nom /= gcd;
            denom /= gcd;
        }
    }
}