using FindPrimeNumbers.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace FindPrimeNumbers.FileMethods
{
    //unused
    public static class ReadDataFromFile
    {

        public static string ReadXml()
        {
            string path = Directory.GetCurrentDirectory() +
                StringsData.FileName +
                DateTime.Now.Year +
                DateTime.Now.Month +
                DateTime.Now.Day +
                StringsData.FileType;

            var list = new List<XmlDataModel>();

            using (StreamReader sr = new StreamReader(path))
            {
                return sr.ReadToEnd();
                //foreach (var line in employeeList.Items)
                //{
                //    Employee e = (Employee)line; // unbox once
                //    sw.WriteLine(e.FirstName);
                //    sw.WriteLine(e.LastName);
                //    sw.WriteLine(e.JobTitle);
                //}
            }
        }
    }
}