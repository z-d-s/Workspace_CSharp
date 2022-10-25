using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Event
{
    public delegate void BoilerLogHandler(string status);
    
    internal class DelegateBoilerEvent
    {
        public event BoilerLogHandler BoilerEventLog;

        public void LogProcess()
        {
            string remarks = "O. K";
            Boiler b = new Boiler(100, 12);
            int t = b.GetTemp();
            int p = b.GetPressure();
            if(t > 150 || t < 80 || p < 12 || p > 15)
            {
                remarks = "Need Maintenance";
            }

            OnBoilerEventLog("Logging Info:\n");
            OnBoilerEventLog("Temparature " + t + "\nPressure: " + p);
            OnBoilerEventLog("\nMessage:" + remarks);
        }

        protected void OnBoilerEventLog(string msg)
        {
            if(BoilerEventLog != null)
            {
                BoilerEventLog(msg);
            }
        }
    }
}
