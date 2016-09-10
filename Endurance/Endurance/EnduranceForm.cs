using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Endurance
{
    public partial class EnduranceForm : Form
    {
        public string TimeLeftTxt
        {
            get
            {
                return timeLeftLbl.Text;
            }
            set
            {
                timeLeftLbl.Text = value;
            }
        }

        #region Methods
        public EnduranceForm(bool running)
        {
            InitializeComponent();

            if (running)
            {
                Start();
            }
            else
            {
                Reset();
            }

            delayTimePicker.Value = DateTime.Today + Endurance.TimeToRun;
            startStopBtn.Focus();
        }

        public void Reset()
        {
            timeLeftLbl.Text = "";
            timedRunBx.Enabled = true;
            delayTimePicker.Enabled = Endurance.TimedRun;
            startStopBtn.Text = Endurance.startText;
            timedRunBx.Checked = Endurance.TimedRun;
        }

        public void Start()
        {
            timedRunBx.Enabled = false;
            delayTimePicker.Enabled = false;
            startStopBtn.Text = Endurance.stopText;
        }

        private void countDownBx_CheckedChanged(object sender, EventArgs e)
        {
            delayTimePicker.Enabled = timedRunBx.Checked;
            Endurance.TimedRun = timedRunBx.Checked;
        }

        private void startStopBtn_Click(object sender, EventArgs e)
        {
            switch (startStopBtn.Text)
            {
                case Endurance.startText:
                    Endurance.Start();
                    break;
                case Endurance.stopText:
                default:
                    Endurance.Reset();
                    break;
            }
        }

        private void delayTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Endurance.TimeToRun = delayTimePicker.Value - DateTime.Today;
        }
        #endregion
    }
}
