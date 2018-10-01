using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TplNetwork
{
    class Thread1
    {
        static void Test1()
        {
            for(int i=1;i<20;i++)
            {
                Console.WriteLine("Test1 method " + i);
            }            
        }
        static void Test2()
        {
            Console.WriteLine("Test2 starts ");
            for (int i = 1; i < 60; i++)
            {
                Console.WriteLine("Test2  :" + i);
                if (i == 50)
                    Thread.Sleep(5000);
            }
                Console.WriteLine("Test2 ends ");
            
        }
        static void Test3()
        {
            for (int i = 1; i < 50; i++)
            {
                Console.WriteLine("Test3 method " + i);
            }
        }
        static void Main(string[] args)
        {
            Test1();
            Test2();
            Test3();
            Console.Read();
        }
    }
}
