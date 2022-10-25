using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Stack
{
    internal class Program
    {
        class A
        {
            public int i;

            public void Method_01()
            {
                int value1 = 10;
                int value2 = 20;
                int value3 = Add(value1, value2);
            }

            public void Method_02()
            {
                double CarPrice;
                Car car01 = new Car();
                CarPrice = car01.GetPrice();
                Console.WriteLine($"CarPrice = {CarPrice}");
                Car car02 = new BMW();
                CarPrice = car02.GetPrice();
                Console.WriteLine($"CarPrice = {CarPrice}");
                car02.Run();
                Car.Purpose();
            }

            public int Add(int v1, int v2)
            {
                int sum = v1 + v2;
                return sum;
            }
        }

        static void Main(string[] args)
        {
            int i = 110;
            Object obj = i;
            i = 220;
            Console.WriteLine($"i = {i} obj = {obj}");
            obj = 330;
            Console.WriteLine($"i = {i} obj = {obj}");

            A a = new A();
            a.i = 100;
            A b = a;
            Console.WriteLine($"a.i = {a.i} b.i = {b.i}");
            a.i = 1234;
            Console.WriteLine($"a.i = {a.i} b.i = {b.i}");
            Console.WriteLine($"a == b : {a == b}");

            A a1 = new A();
            a1.i = 666;
            A a2 = new A();
            a2.i = 789;

            //a.Method_01();
            a.Method_02();

            Console.ReadKey();
        }
    }
}
