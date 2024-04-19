using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPrimeNumbers.FileMethods
{
    public static class GetFileDirectory
    {
        public static string Get()
        {
            return Directory.GetCurrentDirectory() +
                        StringsData.FileName +
                        DateTime.Now.Year +
                        DateTime.Now.Month +
                        DateTime.Now.Day +
                        StringsData.FileType;
        }
    }
}
