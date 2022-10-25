using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Stack
{
    internal class Car
    {
        public void Run()
        {
            Console.WriteLine("一切正常");
        }

        public virtual double GetPrice()
        {
            return 0;
        }

        public static void Purpose()
        {
            Console.WriteLine("载人");
        }
    }
}
