using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Abstract
{
    internal class Rectangle : Shape
    {
        private int length;
        private int width;

        public Rectangle(int _length, int _width)
        {
            length = _length;
            width = _width;
        }
        
        public override int area()
        {
            Console.WriteLine("Rectangle::area:");
            return length * width;
        }
    }
}
