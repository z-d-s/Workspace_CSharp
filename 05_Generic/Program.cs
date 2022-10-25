using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Generic
{
    public class MyGenericArray<T>
    {
        private T[] array;

        public MyGenericArray(int size)
        {
            array = new T[size];
        }

        public T getItem(int index)
        {
            return array[index];
        }

        public void setItem(int index, T value)
        {
            array[index] = value;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyGenericArray<int> intArray = new MyGenericArray<int>(5);
            for(int i = 0; i < 5; ++i)
            {
                intArray.setItem(i, i * 5);
            }
            for(int i = 0; i < 5; ++i)
            {
                Console.Write(intArray.getItem(i));
            }
            Console.WriteLine();

            MyGenericArray<char> charArray = new MyGenericArray<char>(8);
            for(int i = 0; i < 8; ++i)
            {
                charArray.setItem(i, (char)(i + 97));
            }
            for(int i = 0; i < 8; ++i)
            {
                Console.Write(charArray.getItem(i));
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
