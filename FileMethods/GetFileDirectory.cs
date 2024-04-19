using System;
using System.IO;
using System.Windows.Forms;

namespace FindPrimeNumbers.FileMethods
{
    public static class GetFileDirectory
    {
        public static string FilePatch { 
            get  
            { 
                if (filePatch == null) {

                    filePatch = Directory.GetCurrentDirectory() +
                            StringsData.FileName +
                            DateTime.Now.Year +
                            DateTime.Now.Month +
                            DateTime.Now.Day +
                            StringsData.FileType;

                };
                return filePatch; 
            }

            set { filePatch = value; } }

        private static string filePatch { get; set; }

        public static void SetPatch()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "XML|*.xml";
            saveFileDialog1.Title = "Save location";
            saveFileDialog1.FileName = StringsData.FileName +
                                            DateTime.Now.Year +
                                            DateTime.Now.Month +
                                            DateTime.Now.Day;
            saveFileDialog1.ShowDialog();
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();

            FilePatch = saveFileDialog1.FileName;
        }
    }
}
