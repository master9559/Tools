using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Endurance
{
    static class Endurance
    {
        #region Variables
        public const string startText = "Start";
        public const string stopText = "Stop";

        public static TimeSpan TimeToRun;
        public static bool TimedRun = true;

        static Timer timer = new Timer();
        static DateTime tickTime;

        static EnduranceForm enduranceForm;
        static NotifyIcon enduranceIcon;
        static ContextMenu trayMenu;
        static MenuItem startStopItm;
        static MenuItem openItm;
        static MenuItem exitItm;
        #endregion

        #region Methods
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            TimeToRun = TimeSpan.FromMinutes(30);

            newForm();
            enduranceIcon = new NotifyIcon();
            setupTrayIcon();

            Application.Run();
        }

        public static void Start()
        {
            setTickTime();
            startStopItm.Text = stopText;
            enduranceForm.Start();
            timer.Start();
        }

        public static void Reset()
        {
            enduranceForm.Reset();
            startStopItm.Text = startText;
            timer.Stop();
        }

        private static void setupTrayIcon()
        {
            startStopItm = new MenuItem();
            startStopItm.Text = startText;
            startStopItm.Click += startStopBtn_Click;

            openItm = new MenuItem();
            openItm.Text = "Open";
            openItm.Click += openBtn_Click;

            exitItm = new MenuItem();
            exitItm.Text = "Exit";
            exitItm.Click += exitBtn_Click;

            trayMenu = new ContextMenu();
            trayMenu.MenuItems.Add(startStopItm);
            trayMenu.MenuItems.Add(openItm);
            trayMenu.MenuItems.Add(exitItm);

            enduranceIcon.ContextMenu = trayMenu;
            enduranceIcon.Icon = Properties.Resources.endurance;
            enduranceIcon.Visible = true;
            enduranceIcon.Text = "Endurance";
        }

        static void newForm() {
            enduranceForm = new EnduranceForm();
            enduranceForm.Show();
        }

        static void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        static void openBtn_Click(object sender, EventArgs e)
        {
            if (enduranceForm.WindowState == FormWindowState.Minimized)
            {
                enduranceForm.WindowState = FormWindowState.Normal;
            }
            enduranceForm.Activate();
        }

        static void startStopBtn_Click(object sender, EventArgs e)
        {
            switch (startStopItm.Text)
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

        #region private
        static void timer_Tick(object sender, EventArgs e)
        {
            if (TimedRun)
            {
                if (DateTime.Now < tickTime)
                {
                    TimeSpan left = tickTime - DateTime.Now;
                    enduranceForm.TimeLeftTxt = printTime(left);
                }
                else
                {
                    Reset();
                }
            }
            else
            {
                TimeSpan elapsed = DateTime.Now - tickTime;
                enduranceForm.TimeLeftTxt = printTime(elapsed);
            }

            SetThreadExecutionState(1);
        }

        [DllImport("Kernel32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        static extern uint SetThreadExecutionState(int esFlags);

        static void setTickTime()
        {
            if (TimedRun)
            {
                tickTime = DateTime.Now + TimeToRun;
            }
            else
            {
                tickTime = DateTime.Now;
            }
        }

        static string printTime(TimeSpan time)
        {
            string rtnString = "";
            int hours = (int)time.TotalHours;
            if (hours > 0)
            {
                rtnString += hours + " H ";
                time -= TimeSpan.FromHours(hours);
            }

            if (!String.IsNullOrEmpty(rtnString) || time.Minutes > 1)
            {
                rtnString += time.Minutes + " M ";
                time -= TimeSpan.FromMinutes(time.Minutes);
            }

            int seconds = (int)time.TotalSeconds;
            if (String.IsNullOrEmpty(rtnString))
            {
                rtnString += seconds + "." + time.Milliseconds / 100 + " S";
            }
            else
            {
                rtnString += seconds + " S";
            }
            return rtnString;
        }
        #endregion
        #endregion
    }
}
