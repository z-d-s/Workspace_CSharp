using System;
using System.Collections;
using System.Collections.Generic;

namespace _04_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1、List:泛型容器，顺序结构
            List<string> listNew = new List<string>();

            //2、LinkedList:泛型链表，连式结构
            LinkedList<string> linkedListNew = new LinkedList<string>();

            //3、泛型hash表
            Dictionary<string, string> dir = new Dictionary<string, string>();

            //4、hash表
            Hashtable h = new Hashtable();

            //5、堆栈
            Stack s = new Stack();

            //6、队列
            Queue q = new Queue();

            TestYield ty = new TestYield();
            ty.Show(10);

            Console.ReadKey();
        }
    }
}
