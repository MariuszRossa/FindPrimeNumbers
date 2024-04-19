using static System.Net.Mime.MediaTypeNames;
using System.Globalization;
using System;

namespace FindPrimeNumbers.Extensions
{
    public static class NumericTryParse
    {
        public static long LongTryParse(dynamic number)
        {
            number = Math.Floor(number);
            string toParse = number.ToString();
            long parseResult = 0;
            long.TryParse(toParse, out parseResult);

            return parseResult;
        }

        public static int IntTryParse(dynamic number)
        {
            number = Math.Floor(number);
            string toParse = number.ToString();
            int parseResult = 0;
            int.TryParse(toParse, out parseResult);

            return parseResult;
        }
    }
}
