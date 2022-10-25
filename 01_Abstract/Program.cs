using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Abstract
{
    class MyClass
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(13, 28);
            int a = rect.area();
            Console.WriteLine(a);

            MyClass mc = new MyClass();
            mc.Name = "aaaa";
            Console.WriteLine(mc.Name);

            Console.ReadKey();
        }
    }
}
