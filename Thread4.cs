using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace TplNetwork
{
    class Thread4
    {
        static void Test1()
        {
            Console.WriteLine("Test1 starts ");
            for (int i = 1; i < 20; i++)
            {
                Console.WriteLine("Test1 method : " + i);
            }
            Console.WriteLine("Test1 ends ");
        }
        static void Test2()
        {
            Console.WriteLine("Test2 starts ");
            for (int i = 1; i < 60; i++)
            {
                Console.WriteLine("Test2  method :" + i);
                if (i == 50)
                    Thread.Sleep(5000);
            }
            Console.WriteLine("Test2 ends ");

        }
        static void Test3()
        {
            Console.WriteLine("Test3 starts ");
            for (int i = 1; i < 50; i++)
            {
                Console.WriteLine("Test3 method : " + i);
            }
            Console.WriteLine("Test3 ends ");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread starts");
            Thread Thread1 = new Thread(Test1);
            Thread Thread2 = new Thread(Test2);
            Thread Thread3 = new Thread(Test3);
            Thread1.Start();
            Thread2.Start();
            Thread3.Start();
            Thread1.Join();Thread2.Join();Thread3.Join();
            Console.WriteLine("Main Thread ends");
            Console.Read();
        }
    }
}
