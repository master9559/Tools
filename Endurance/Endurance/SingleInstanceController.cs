using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Endurance
{
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

            Endurance.OpenForm();
            return false;
        }

        protected override void OnStartupNextInstance(StartupNextInstanceEventArgs e)
        {
            base.OnStartupNextInstance(e);
            try
            {
                if (!Endurance.Loaded)
                {

                }
                else
                {
                    args = e.CommandLine.ToArray();
                    Endurance.OpenForm();
                    processCommandLine();
                }
            }
            catch (Exception exc)
            {
            }
        }

        private void processCommandLine()
        {
        }
    }
}
