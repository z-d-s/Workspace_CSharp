using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate int NumberChanger(int n);

namespace _07_Delegate
{
    internal class TestDelegate
    {
        static int num = 100;

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MulNum(int q)
        {
            num *= q;
            return num;
        }

        public static int GetNum()
        {
            return num;
        }

        static void Main(string[] args)
        {
            //创建委托实例
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MulNum);
            NumberChanger nc3;
            //nc3 = nc1 + nc2;
            nc3 = nc1;
            nc3 += nc2;
            nc3(5);
            Console.WriteLine($"nc1 = {GetNum()}");

            //nc1(25);
            //Console.WriteLine($"nc1 = {GetNum()}");

            //nc2(5);
            //Console.WriteLine($"nc2 = {GetNum()}");

            Console.ReadKey();
        }
    }
}
