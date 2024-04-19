using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FindPrimeNumbers.Models
{
    [DataContract(Name = "Cycle_Data")]
    public class XmlDataModel
    {
        [DataMember(Name = "Cycle")]
        public int CycleNumber { get; set; }

        [DataMember(Name = "Value")]
        public long FoundValue { get; set; }

        [DataMember(Name = "Cycle_Runtime_In_Second")]
        public double CycleElapsedTime { get; set; }

        [DataMember(Name = "App_Runtime_In_Second")]
        public double ElapsedTime { get; set; }

        [DataMember(Name = "Start_Time")]
        public DateTime CycleStartTime { get; set; } = new DateTime();

        [DataMember(Name = "End_Time")]
        public DateTime CycleEndTime { get; set; } = new DateTime();
    }

    [DataContract(Name = "Root")]
    public class XmlDataModelList
    {
        [DataMember(Name = "Cycle_List")]
        public List<XmlDataModel> XmlDataModels { get; set; } = new List<XmlDataModel> ();
    }
}
