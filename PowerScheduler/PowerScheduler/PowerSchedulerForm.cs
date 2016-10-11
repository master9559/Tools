using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerScheduler
{
    public partial class PowerSchedulerForm : Form
    {
        #region Variables
        const string startText = "Start";
        const string abortText = "Abort";

        Timer timer = new Timer();
        DateTime endTime;
        #endregion

        #region methods
        public PowerSchedulerForm()
        {
            InitializeComponent();

            timeLeftLbl.Text = "";
            startStopBtn.Text = startText;
            scheduleLbl.Visible = false;
            dateTimePicker.Visible = false;
            delayTimePicker.Visible = false;

            dateTimePicker.Value = DateTime.Now;
            delayTimePicker.Value = DateTime.Today;

            timer.Tick += Timer_Tick;
            powerOptionCB.SelectedIndex = 0;
            timeOptionsCB.SelectedIndex = 1;
            startStopBtn.Focus();
        }

        [DllImport("PowrProf.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        private static extern bool SetSuspendState(bool hiberate, bool forceCritical, bool disableWakeEvent);

        private bool powerAction()
        {
            switch ((string)powerOptionCB.SelectedItem)
            {
                case "Sleep":
                    return SetSuspendState(false, true, true);
                case "Shutdown":
                    Process s = Process.Start("Shutdown", "/s");
                    return s.ExitCode == 0;
                case "Restart":
                    Process r = Process.Start("Shutdown", "/r");
                    return r.ExitCode == 0;
            }
            return false;
        }

        private void setEndTime()
        {
            switch ((string)timeOptionsCB.SelectedItem)
            {
                case "Now":
                    endTime = DateTime.Now;
                    break;
                case "Delayed":
                    TimeSpan delayTime = delayTimePicker.Value - DateTime.Today;
                    endTime = DateTime.Now + delayTime;
                    break;
                case "Specific Time":
                    endTime = dateTimePicker.Value;
                    break;
            }
        }

        private void toggleControls(bool on)
        {
            timeLeftLbl.Visible = !on;
            powerOptionCB.Enabled = on;
            timeOptionsCB.Enabled = on;
            dateTimePicker.Enabled = on;
            delayTimePicker.Enabled = on;
        }

        #region Events
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now >= endTime)
            {
                timeLeftLbl.Text = "0.0 S";
                timer.Stop();
                if (powerAction())
                {
                    Application.Exit();
                }
            }
            else
            {
                timeLeftLbl.Text = "";
                TimeSpan timeLeft = endTime - DateTime.Now;
                int hours = (int)timeLeft.TotalHours;
                if (hours > 0)
                {
                    timeLeftLbl.Text += hours + " H ";
                    timeLeft -= TimeSpan.FromHours(hours);
                }

                if (!String.IsNullOrEmpty(timeLeftLbl.Text) || timeLeft.Minutes > 1)
                {
                    timeLeftLbl.Text += timeLeft.Minutes + " M ";
                    timeLeft -= TimeSpan.FromMinutes(timeLeft.Minutes);
                }

                int seconds = (int)timeLeft.TotalSeconds;
                if (String.IsNullOrEmpty(timeLeftLbl.Text))
                {
                    timeLeftLbl.Text += seconds + "." + timeLeft.Milliseconds / 100 + " S";
                    if (!TopMost && seconds < 30)
                    {
                        Activate();
                        TopMost = true;
                    }
                }
                else
                {
                    timeLeftLbl.Text += seconds + " S";
                }

                SetThreadExecutionState(3);
            }
        }

        private void powerOptionCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            startStopBtn.Focus();
        }

        private void timeOptionsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((string)timeOptionsCB.SelectedItem)
            {
                case "Now":
                    scheduleLbl.Visible = false;
                    dateTimePicker.Visible = false;
                    delayTimePicker.Visible = false;
                    Size = MinimumSize;
                    break;
                case "Delayed":
                    scheduleLbl.Visible = true;
                    dateTimePicker.Visible = false;
                    delayTimePicker.Visible = true;
                    Height = MaximumSize.Height;
                    Width = MinimumSize.Width;
                    break;
                case "Specific Time":
                    scheduleLbl.Visible = true;
                    dateTimePicker.Visible = true;
                    delayTimePicker.Visible = false;
                    Size = MaximumSize;
                    dateTimePicker.Value = DateTime.Now;
                    break;
            }
            startStopBtn.Focus();
        }

        private void startStopBtn_Click(object sender, EventArgs e)
        {
            switch (startStopBtn.Text)
            {
                case startText:
                    toggleControls(false);
                    startStopBtn.Text = abortText;
                    setEndTime();
                    timer.Start();
                    break;
                case abortText:
                default:
                    toggleControls(true);
                    startStopBtn.Text = startText;
                    timeLeftLbl.Text = "";
                    timer.Stop();
                    TopMost = false;
                    break;
            }
        }

        [DllImport("Kernel32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        static extern uint SetThreadExecutionState(int esFlags);
        #endregion
        #endregion
    }
}
