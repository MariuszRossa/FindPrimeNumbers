using FindPrimeNumbers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FindPrimeNumbers.PrimeCalculator
{
    public class Calculate : ICalculate
    {

        public static long CalculatedValue { get => _calculatedValue; private set { _calculatedValue = value; } }

        private static long _calculatedValue = 0;

        private static long searchValue = 3;

        public void Run()
        {
            bool notPrimeNb = true;
            long i = searchValue;

            {
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
        }

        public void ClearData() 
        {
            _calculatedValue = 0;
            searchValue = 3;
        }
    }
}
