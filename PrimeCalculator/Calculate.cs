using FindPrimeNumbers.Interfaces;
using System.Numerics;

namespace FindPrimeNumbers.PrimeCalculator
{
    public class Calculate : ICalculate
    {

        public static BigInteger CalculatedValue { get => _calculatedValue; private set { _calculatedValue = value; } }

        private static BigInteger _calculatedValue = 0;

        private static BigInteger searchValue = 3;

        public void Run()
        {
            bool notPrimeNb = true;
            BigInteger i = searchValue;

            notPrimeNb = true;

            for (long j = 2; j * j <= i; j++)
            {
                if (i % j == 0)
                {
                    notPrimeNb = false;
                    break;
                }
            }
            if (notPrimeNb)
            {
                CalculatedValue = i;
            }

            searchValue += 2;
        }

        public void ClearData() 
        {
            _calculatedValue = 0;
            searchValue = 3;
        }
    }
}
