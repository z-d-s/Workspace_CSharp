using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Event
{
    internal class Program
    {
        static void Logger(string info)
        {
            Console.WriteLine(info);
        }

        static void Main(string[] args)
        {
            BoilerInfoLogger filelog = new BoilerInfoLogger("e:\\boiler.txt");
            DelegateBoilerEvent boilerEvent = new DelegateBoilerEvent();
            boilerEvent.BoilerEventLog += new BoilerLogHandler(Logger);
            boilerEvent.BoilerEventLog += new BoilerLogHandler(filelog.Logger);
            boilerEvent.LogProcess();
            filelog.Close();

            Console.ReadKey();
        }
    }
}
