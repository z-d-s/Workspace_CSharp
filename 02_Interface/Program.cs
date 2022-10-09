using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InterfaceImplementer i = new InterfaceImplementer();
            i.ParentInterfaceMethod();
            i.MethodToImplement();
            i.ShowColor();
            Console.ReadKey();
        }
    }
}
