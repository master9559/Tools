using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCamel
{
    static class Program
    {
        static MainForm mainForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SingleInstanceController singleInstanceController = new SingleInstanceController();
            singleInstanceController.Run(args);
        }

        public class SingleInstanceController : WindowsFormsApplicationBase
        {
            string[] args = null;

            public SingleInstanceController()
            {
                IsSingleInstance = true;
            }

            protected override bool OnStartup(StartupEventArgs e)
            {
                bool returnValue = base.OnStartup(e);
                args = e.CommandLine.ToArray();

                return returnValue;
            }

            protected override void OnStartupNextInstance(StartupNextInstanceEventArgs e)
            {
                base.OnStartupNextInstance(e);
                try
                {
                    if (!mainForm.Loaded)
                    {

                    }
                    else
                    {
                        args = e.CommandLine.ToArray();
                        processCommandLine();
                    }
                }
                catch (Exception exc)
                {
                }
            }

            protected override void OnCreateMainForm()
            {
                try
                {
                    mainForm = new MainForm();
                    MainForm = mainForm;
                    processCommandLine();
                }
                catch (Exception e)
                {
                    Environment.Exit(1);
                }
            }

            private void processCommandLine()
            {
            }
        }
    }
}
