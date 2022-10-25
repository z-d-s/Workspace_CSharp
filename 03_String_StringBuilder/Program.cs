using System;
using System.IO;
using System.Security;
using System.Text;

/***
 * String:
 *  1、String是System命名空间下的一个类
 *  2、String是创建了一个不可变数据类型，天然线程同步
 *  3、优势：String主要用于公共API，通用性好、用途广泛、读取性能高、占用内存小
 * StringBuilder:
 *  1、StringBuilder是System.Text命名空间下的一个类
 *  2、用途：StringBuilder主要用于处理字符串拼接，非线程同步
 *  3、StringBuilder底层是字符数组，扩容使用链表处理，并且是头插法(?)
 *  TODO::尾插法不是更容易理解和处理吗？难道有什么特殊处理？
 */
namespace _03_String_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "abc";
            string str2 = "xyz";
            Console.WriteLine($"{str1[0]} {str1.Length}");

            Console.WriteLine(str1);
            Console.WriteLine(str2);

            string str3 = str1 + str2;
            str1 += str2;               //新对象被分配给变量 s1，而分配给 s1 的原始对象被释放
            Console.WriteLine(str1);
            Console.WriteLine(str3);

            var jh = (firstName: "Jupiter", lastName: "Hammon", borm: 1711, published: 1761);
            Console.WriteLine($"{jh.firstName} {jh.lastName}");

            StringBuilder sb = new StringBuilder("abcdefghij");
            sb.Append("0123456789");
            sb.Append("abcdefghij");
            sb.Append("0123456789");
            sb.Append("abcdefghij");
            sb.Append("0123456789");
            Console.WriteLine(sb);

            Console.ReadKey();
        }
    }
}
