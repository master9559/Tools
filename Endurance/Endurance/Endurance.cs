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
        static bool click = false;

        static EnduranceForm enduranceForm;
        static NotifyIcon enduranceIcon;
        static ContextMenu trayMenu;
        static MenuItem startStopItm;
        static MenuItem openItm;
        static MenuItem exitItm;

        const int longInterval = 60000;
        const int shortInterval = 1000;

        internal static bool Loaded
        {
            get
            {
                return loaded;
            }
        }
        static bool loaded = false;
        #endregion

        #region Methods
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static Endurance()
        {
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            TimeToRun = TimeSpan.FromMinutes(30);

            newForm();
            enduranceIcon = new NotifyIcon();
            setupTrayIcon();

            loaded = true;
            Application.Run();
        }

        public static void Start()
        {
            setTickTime();
            startStopItm.Text = stopText;
            enduranceForm.Start();
            timer.Interval = shortInterval;
            timer.Start();
        }

        public static void Reset()
        {
            enduranceForm.Reset();
            startStopItm.Text = startText;
            enduranceIcon.BalloonTipText = "";
            timer.Stop();
        }

        public static void OpenForm()
        {
            if (enduranceForm.IsDisposed)
            {
                newForm();
            }
            if (enduranceForm.WindowState == FormWindowState.Minimized)
            {
                enduranceForm.WindowState = FormWindowState.Normal;
            }
            enduranceForm.Activate();
            if (timer.Enabled)
            {
                timer_Tick(null, null);
            }
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
            enduranceIcon.BalloonTipTitle = "Endurance";
            enduranceIcon.DoubleClick += openBtn_Click;
            enduranceIcon.MouseClick += EnduranceIcon_Click;
        }

        #region private
        static void setInterval(TimeSpan time)
        {
            if (time.TotalMinutes > 2)
            {
                timer.Interval = longInterval;
            }
            else
            {
                timer.Interval = shortInterval;
            }
        }

        static void newForm()
        {
            enduranceForm = new EnduranceForm(timer.Enabled);
            enduranceForm.Show();
        }

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

        static void printTime(TimeSpan time)
        {
            string timeString = "";

            int days = (int)time.TotalDays;
            if (days > 0)
            {
                timeString += days + " Day" + (days > 1 ? "s " : " ");
                time -= TimeSpan.FromDays(days);
            }

            if (time.Hours > 0)
            {
                timeString += time.ToString(@"hh\:mm");
            }
            else if (time.Minutes > 0)
            {
                timeString += time.Minutes + " Minute" + (time.Minutes > 1 ? "s" : "");
            }
            else
            {
                timeString += time.Seconds + " Second" + (time.Seconds > 1 ? "s" : "");
            }
            enduranceForm.TimeLeftTxt = timeString;
            enduranceIcon.BalloonTipText = timeString;
        }

        static void exitBtn_Click(object sender, EventArgs e)
        {
            enduranceForm.Close();
            enduranceIcon.Visible = false;
            enduranceForm.Dispose();
            enduranceIcon.Dispose();
            Application.Exit();
        }

        static void openBtn_Click(object sender, EventArgs e)
        {
            click = false;
            OpenForm();
        }

        private static void EnduranceIcon_Click(object sender, MouseEventArgs e)
        {
            click = true;
            System.Threading.Thread.Sleep(200);
            if (e.Button == MouseButtons.Left && click
                && !String.IsNullOrEmpty(enduranceIcon.BalloonTipText))
            {
                enduranceIcon.ShowBalloonTip(3000);
            }
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

        static void timer_Tick(object sender, EventArgs e)
        {
            if (TimedRun)
            {
                if (DateTime.Now < tickTime)
                {
                    TimeSpan left = tickTime - DateTime.Now;
                    printTime(left);
                    setInterval(left);
                }
                else
                {
                    enduranceIcon.ShowBalloonTip(3000, "Endurance", "Endurance has stopped", enduranceIcon.BalloonTipIcon);
                    Reset();
                }
            }
            else
            {
                TimeSpan elapsed = DateTime.Now - tickTime;
                printTime(elapsed);
                setInterval(elapsed);
            }

            SetThreadExecutionState(3);
        }

        [DllImport("Kernel32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        static extern uint SetThreadExecutionState(int esFlags);
        #endregion
        #endregion
    }
}
