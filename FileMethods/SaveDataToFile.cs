using FindPrimeNumbers.Interfaces;
using FindPrimeNumbers.Models;
using FindPrimeNumbers.Properties;
using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace FindPrimeNumbers.FileMethods
{
    public class SaveDataToFile : IXmlDataSave
    {
        public string GetPatch { get => _patch; }

        private string _patch;


        public SaveDataToFile()
        {
            _patch = GetFileDirectory.Get();
        }

        public void Save(XmlDataModel cycleData)
        {
            try
            {
                if (!File.Exists(GetPatch))
                {
                    XmlDataModelList xmlList = new XmlDataModelList();

                    xmlList.XmlDataModels.Add(cycleData);

                    XDocument doc = new XDocument(new XDeclaration("1.0", "utf-8", null));

                    using (XmlWriter writer = doc.CreateWriter())
                    {
                        DataContractSerializer dcs = new DataContractSerializer(xmlList.GetType());

                        dcs.WriteObject(writer, xmlList);

                    }

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

                document.Root.Elements().FirstOrDefault()
                    .Add(
                    new XElement("CycleData",
                     new XElement("App_Runtime_In_Second", cycleData.ElapsedTime),
                     new XElement("Cycle", cycleData.CycleNumber),
                     new XElement("Cycle_Runtime_In_Second", cycleData.CycleElapsedTime),
                     new XElement("End_Time", cycleData.CycleEndTime),
                     new XElement("Start_Time", cycleData.CycleStartTime),
                     new XElement("Value", cycleData.FoundValue)
                     ));

                foreach (var node in document.Root.Descendants().Where(n => n.Name.NamespaceName == ""))
                {
                    node.Attributes("xmlns").Remove();

                    node.Name = node.Parent.Name.Namespace + node.Name.LocalName;
                }

                document.Save(GetPatch);
            }
            catch (Exception ex) { MessageBox.Show(StringsData.ErrorAddSave + ex.Message); }
        }
    }
}
