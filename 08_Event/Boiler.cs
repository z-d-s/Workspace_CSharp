using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Event
{
    internal class Boiler
    {
        private int temp;
        private int pressure;
        public Boiler(int _temp, int _pressure)
        {
            temp = _temp;
            pressure = _pressure;
        }

        public int GetTemp()
        {
            return temp;
        }

        public int GetPressure()
        {
            return pressure;
        }
    }
}
