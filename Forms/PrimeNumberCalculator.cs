using FindPrimeNumbers.Extensions;
using FindPrimeNumbers.FileMethods;
using FindPrimeNumbers.Interfaces;
using FindPrimeNumbers.Models;
using FindPrimeNumbers.PrimeCalculator;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace FindPrimeNumbers.Forms
{
    public partial class PrimeNumberCalculator : Form
    {
        private IXmlDataSave _xmlDataSave;

        private ICalculate _calculate;

        private TaskSchedulerExtension taskSchedulerExtension;

        private TimerModel timerData;

        private Stopwatch stopWatch;

        private System.Timers.Timer cycleTimer;

        private XmlDataModel cycleData;

        public PrimeNumberCalculator()
        {
            InitializeComponent();

            _xmlDataSave = new SaveDataToFile();
            _calculate = new Calculate();

            taskSchedulerExtension = new TaskSchedulerExtension();
            stopWatch = new Stopwatch();

            cycleTimer = new System.Timers.Timer()
            {
                Interval = 1000,
                AutoReset = true,
                Enabled = true
            };
            cycleTimer.Stop();
            cycleTimer.Elapsed += OnTimedEvent;
        }

        private void buttonStart1_Click(object sender, EventArgs e)
        {
            _calculate.ClearData();

            timerData = new TimerModel();
            timerData.StartTime = DateTime.Now;

            cycleData = new XmlDataModel();
            cycleData.CycleStartTime = timerData.StartTime;

            TextBoxSetData();
            SetTimer();
        }

        private void buttonStop2_Click(object sender, EventArgs e)
        {
            StopTimers();

            if (StringsData.CycleWaitTimeSec <= 0) {
                taskSchedulerExtension.CancelSource.Cancel();
            }
        }

        private void SetTimer()
        {
            StopTimers();

            stopWatch.Start();
            cycleTimer.Start();

            taskSchedulerExtension.StartTask();
        }

        private void StopTimers()
        {
            cycleTimer.Stop();
            stopWatch.Stop();
            stopWatch.Reset();
        }
        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            TextBoxSetData();

            if (StringsData.CycleWaitTimeSec > 0)
            {
                //pause condition
                if (Math.Round(stopWatch.Elapsed.TotalSeconds) ==
                    timerData.CycleDurationSec *
                    timerData.CurrentCycle +
                    timerData.CycleWaitTimeSec *
                    (timerData.CurrentCycle - 1) &&
                    timerData.waitTime == false)
                {

                    timerData.waitTime = true;

                    SetCycleData();

                    _xmlDataSave.Save(cycleData);

                    if (timerData.FundedPrimeNumber == Calculate.CalculatedValue)
                    {
                        StopTimers();
                        MessageBox.Show(StringsData.ErrorFindingPrimeNb);
                    }

                    timerData.FundedPrimeNumber = Calculate.CalculatedValue;
                }
                //start condition
                else if (stopWatch.Elapsed.TotalSeconds >=
                        timerData.CycleDurationSec *
                        timerData.CurrentCycle +
                        timerData.CycleWaitTimeSec *
                        timerData.CurrentCycle &&
                        timerData.waitTime == true)
                {
                    timerData.waitTime = false;

                    taskSchedulerExtension.StartTask();

                    timerData.CurrentCycle++;
                }
            }
            else if (Math.Round(stopWatch.Elapsed.TotalSeconds) ==
                    timerData.CycleDurationSec *
                    timerData.CurrentCycle +
                    timerData.CycleWaitTimeSec *
                    (timerData.CurrentCycle - 1))
            {
                SetCycleData();

                _xmlDataSave.Save(cycleData);

                timerData.CurrentCycle++;
            }
        }

        private void SetCycleData()
        {
            cycleData.CycleNumber = timerData.CurrentCycle;
            cycleData.FoundValue = Calculate.CalculatedValue;
            cycleData.CycleElapsedTime = (DateTime.Now - cycleData.CycleStartTime).TotalSeconds;
            cycleData.CycleEndTime = DateTime.Now;
            cycleData.ElapsedTime = (cycleData.CycleEndTime - timerData.StartTime).TotalSeconds;
        }

        private void TextBoxSetData()
        {
            timerData.ElapsedTime = LongTryParse.TryParse((DateTime.Now - timerData.StartTime).Seconds.ToString());

            TextBoxRefresh.RefreshText(textBoxClock1, timerData.ElapsedTime);
            TextBoxRefresh.RefreshText(textBoxPrimeNumber3, Calculate.CalculatedValue);
            TextBoxRefresh.RefreshText(textBoxCycleNumber2, timerData.CurrentCycle);
        }
    }
}
