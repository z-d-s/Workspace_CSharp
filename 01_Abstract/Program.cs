using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(13, 28);
            int a = rect.area();
            Console.WriteLine(a);

            Console.ReadKey();
        }
    }
}
