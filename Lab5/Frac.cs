using System.Numerics;

namespace Lab5
{
    public class Frac : IMyNumber<Frac>
    {
        private BigInteger _nom;
        private BigInteger _denom;

        public BigInteger Nom
        {
            get => _nom;
            set => _nom = value;
        }

        public BigInteger Denom
        {
            get => _denom;
            set => _denom = value;
        }

        public Frac(BigInteger nom, BigInteger denom)
        {
            _nom = nom;
            _denom = denom;
        }

        public Frac Add(Frac obj)
        {
            return new Frac(
                BigInteger.Add(BigInteger.Multiply(this.Nom, obj.Denom),
                    BigInteger.Multiply(this.Denom, obj.Nom)),
                BigInteger.Multiply(this.Denom, obj.Nom));
        }

        public Frac Substract(Frac obj)
        {
            throw new System.NotImplementedException();
        }

        public Frac Multiply(Frac obj)
        {
            throw new System.NotImplementedException();
        }

        public Frac Devide(Frac obj)
        {
            throw new System.NotImplementedException();
        }
    }
}