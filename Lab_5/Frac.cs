using System.Numerics;

namespace Lab5
{
    public class Frac : IMyNumber<Frac>
    {
        private BigInteger _nom;
        private BigInteger _denom;

        public BigInteger nom
        {
            get => _nom;
            set => _nom = value;
        }

        public BigInteger denom
        {
            get => _denom;
            set => _denom = value;
        }

        public Frac(BigInteger nom, BigInteger denom)
        {
            _nom = nom;
            _denom = denom;
        }

        public Frac Add(Frac that)
        {
            return new Frac(this.nom * that.denom + that.nom * this.denom, this.denom * that.denom);

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

        public override string ToString()
        {
            return $"{nom}/{denom}";
        }
    }
}