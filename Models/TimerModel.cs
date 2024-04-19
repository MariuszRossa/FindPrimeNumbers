using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPrimeNumbers.Models
{
    public class TimerModel
    {
        public int CycleDurationSec { get; set; } = StringsData.CycleDurationSec;
        public int CycleWaitTimeSec { get; set; } = StringsData.CycleWaitTimeSec;

        public DateTime StartTime { get; set; }
        public DateTime RunEndTime { get; set; }

        public long ElapsedTime { get; set; } = 0;
        public int CurrentCycle { get; set; } = 1;

        public long FundedPrimeNumber { get; set; }

        public bool waitTime { get; set; }
    }
}
