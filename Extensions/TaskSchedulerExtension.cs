using FindPrimeNumbers.Interfaces;
using FindPrimeNumbers.PrimeCalculator;
using System.Threading;
using System.Threading.Tasks;

namespace FindPrimeNumbers.Extensions
{
    public class TaskSchedulerExtension
    {
        public CancellationTokenSource CancelSource { get; set; }

        private ICalculate _calculate;

        public TaskSchedulerExtension()
        {
            _calculate = new Calculate();
        }

        public void StartTask()
        {
            CancelSource = new CancellationTokenSource();

            if (StringsData.CycleWaitTimeSec > 0) {
                CancelSource.CancelAfter(StringsData.CycleWaitTimeSec * 1000);
            }

            Task.Run(() =>
            {
                while (!CancelSource.Token.IsCancellationRequested) {
                    _calculate.Run();
                }
            });
        }
    }
}
