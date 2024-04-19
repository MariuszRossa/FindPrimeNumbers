using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPrimeNumbers.Extensions
{
    public static class LongTryParse
    {
        public static long TryParse(string toParse)
        {
            long parseResult = 0;
            long.TryParse(toParse, out parseResult);
            return parseResult;
        }
    }
}
