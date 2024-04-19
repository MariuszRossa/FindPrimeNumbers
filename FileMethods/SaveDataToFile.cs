using FindPrimeNumbers.Interfaces;
using FindPrimeNumbers.Models;
using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace FindPrimeNumbers.FileMethods
{
    public class SaveDataToFile : IXmlDataSave
    {
        public string GetPatch { get => GetFileDirectory.FilePatch; }

        public void Save(XmlDataModel cycleData)
        {
            try
            {
                if (!File.Exists(GetPatch))
                {
                    XDocument doc = new XDocument(new XDeclaration("1.0", "utf-8", null),

                        new XElement("Root",
                        new XElement("CycleData",
                             new XElement("App_Runtime_In_Second", cycleData.ElapsedTime),
                             new XElement("Cycle", cycleData.CycleNumber),
                             new XElement("Cycle_Runtime_In_Second", cycleData.CycleElapsedTime),
                             new XElement("End_Time", cycleData.CycleEndTime),
                             new XElement("Start_Time", cycleData.CycleStartTime),
                             new XElement("Value", cycleData.FoundValue))));

                    doc.Root.Save(GetPatch);
                }

                else
                {
                    AddElement(cycleData);
                }
            }
            catch (Exception ex) { MessageBox.Show(StringsData.ErrorSave + ex.Message); }
        }

        private void AddElement(XmlDataModel cycleData)
        {
            try
            {
                XDocument document = XDocument.Load(GetPatch);

                document.Root
                    .Add(
                    new XElement("CycleData",
                     new XElement("App_Runtime_In_Second", cycleData.ElapsedTime),
                     new XElement("Cycle", cycleData.CycleNumber),
                     new XElement("Cycle_Runtime_In_Second", cycleData.CycleElapsedTime),
                     new XElement("End_Time", cycleData.CycleEndTime),
                     new XElement("Start_Time", cycleData.CycleStartTime),
                     new XElement("Value", cycleData.FoundValue)
                     ));

                document.Save(GetPatch);
            }
            catch (Exception ex) { MessageBox.Show(StringsData.ErrorAddSave + ex.Message); }
        }
    }
}
