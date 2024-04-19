using System;
using System.Numerics;

namespace FindPrimeNumbers.Models
{
    public class TimerModel
    {
        public int CycleDurationSec { get; set; } = CycleRunTimesModel.CycleDurationSec;
        public int CycleWaitTimeSec { get; set; } = CycleRunTimesModel.CycleWaitTimeSec;

        public DateTime StartTime { get; set; }
        public DateTime RunEndTime { get; set; }

        public long ElapsedTime { get; set; } = 0;
        public int CurrentCycle { get; set; } = 1;

        public BigInteger FundedPrimeNumber { get; set; }

        public bool waitTime { get; set; }
    }
}
