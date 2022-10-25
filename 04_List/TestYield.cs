using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _04_List
{
    internal class TestYield
    {
        List<int> Fibonacci_01(int count)
        {
            int p = 1;
            int c = 1;

            List<int> result = new List<int>();
            for(int i = 0; i < count; ++i)
            {
                result.Add(p);
                Console.WriteLine($"before i : {i}");
                Thread.Sleep(500);
                Console.WriteLine($"after i : {i}");

                int temp = p + c;
                p = c;
                c = temp;
            }
            return result;
        }

        IEnumerable<int> Fibonacci_02(int count)
        {
            int p = 1;
            int c = 1;

            List<int> result = new List<int>();
            for (int i = 0; i < count; ++i)
            {
                yield return p;
                Console.WriteLine($"before i : {i}");
                Thread.Sleep(500);
                Console.WriteLine($"after i : {i}");

                int temp = p + c;
                p = c;
                c = temp;
            }
        }

        public void Show(int count)
        {
            IEnumerable<int> fibonacci = Fibonacci_01(count);
            foreach(var f in fibonacci)
            {
                Console.WriteLine($"{f}");
            }
        }
    }
}
