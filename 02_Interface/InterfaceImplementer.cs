using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Interface
{
    internal class InterfaceImplementer : IMyInterface, IColor
    {
        public void ParentInterfaceMethod()
        {
            Console.WriteLine("InterfaceImplementer::ParentInterfaceMethod() is called!");
        }

        public void MethodToImplement()
        {
            Console.WriteLine("InterfaceImplementer::MethodToImplement() is called!");
        }

        public void ShowColor()
        {
            Console.WriteLine("InterfaceImplementer::ShowColor() is called!");
        }
    }
}
