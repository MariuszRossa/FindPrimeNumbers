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

            ConfigureTimers();
            SetSaveLocalization();
        }

        private void buttonStart1_Click(object sender, EventArgs e)
        {
            _calculate.ClearData();

            timerData = new TimerModel();
            timerData.StartTime = DateTime.Now;

            cycleData = new XmlDataModel();
            cycleData.CycleStartTime = timerData.StartTime;

            SetCycleTimes();
            TextBoxSetData();
            SetTimer();
        }

        private void buttonStop2_Click(object sender, EventArgs e)
        {
            StopTimers();
            SetNumericUpDownReadOnly(false);

            if (CycleRunTimesModel.CycleWaitTimeSec <= 0) {
                taskSchedulerExtension.CancelSource.Cancel();
            }
        }

        private void buttonSave3_Click(object sender, EventArgs e)
        {
            GetFileDirectory.SetPatch();
            SetSaveLocalization();
        }

        private void SetCycleTimes()
        {
            CycleRunTimesModel.CycleDurationSec = NumericTryParse.IntTryParse(numericUpDownCycleDur1.Value);
            CycleRunTimesModel.CycleWaitTimeSec = NumericTryParse.IntTryParse(numericUpDownCycleWait2.Value);

            timerData.CycleDurationSec = CycleRunTimesModel.CycleDurationSec;
            timerData.CycleWaitTimeSec = CycleRunTimesModel.CycleWaitTimeSec;

            SetNumericUpDownReadOnly(true);
        }

        private void SetNumericUpDownReadOnly(bool status)
        {
            numericUpDownCycleDur1.ReadOnly = status;
            numericUpDownCycleWait2.ReadOnly = status;
        }

        private void ConfigureTimers()
        {
            cycleTimer = new System.Timers.Timer()
            {
                Interval = 500,
                AutoReset = true,
                Enabled = true
            };
            cycleTimer.Stop();
            cycleTimer.Elapsed += OnTimedEvent;

            stopWatch = new Stopwatch();
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
            if (CycleRunTimesModel.CycleWaitTimeSec > 0)
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

                    CheckPrimeNb();
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
            else if (Math.Floor(stopWatch.Elapsed.TotalSeconds) ==
                    timerData.CycleDurationSec *
                    timerData.CurrentCycle)
            {
                SetCycleData();

                timerData.CurrentCycle++;

                CheckPrimeNb();
            }

            TextBoxSetData();
        }

        private void SetCycleData()
        {
            cycleData.CycleNumber = timerData.CurrentCycle;
            cycleData.FoundValue = Calculate.CalculatedValue;
            cycleData.CycleElapsedTime = (DateTime.Now - cycleData.CycleStartTime).TotalSeconds;
            cycleData.CycleEndTime = DateTime.Now;
            cycleData.ElapsedTime = (cycleData.CycleEndTime - timerData.StartTime).TotalSeconds;

            _xmlDataSave.Save(cycleData);

            cycleData.CycleStartTime = DateTime.Now;
        }

        private void TextBoxSetData()
        {
            timerData.ElapsedTime = NumericTryParse.LongTryParse((DateTime.Now - timerData.StartTime).TotalSeconds);

            TextBoxRefresh.RefreshText(textBoxClock1, timerData.ElapsedTime);
            TextBoxRefresh.RefreshText(textBoxCycleNumber2, timerData.CurrentCycle);
            TextBoxRefresh.RefreshText(textBoxPrimeNumber3, Calculate.CalculatedValue);
        }

        private void SetSaveLocalization()
        {
            textBoxSaveLoc4.Text = GetFileDirectory.FilePatch;
        }

        private void CheckPrimeNb()
        {
            if (Calculate.CalculatedValue == timerData.FundedPrimeNumber)
            {
                StopTimers();
                taskSchedulerExtension.CancelSource.Cancel();
                MessageBox.Show(StringsData.ErrorFindingPrimeNb);
            }

            timerData.FundedPrimeNumber = Calculate.CalculatedValue;
        }
    }
}
