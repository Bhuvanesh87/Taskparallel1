using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TplNetwork
{
    class Thread3
    {
        static void Test1()
        {
            for(int i=1;i<50;i++)
            {
                Console.WriteLine("Test1  : " + i);
            }
        }
        static void Main(string[] args)
        {
            ThreadStart obj = () => Test1();
            Thread t1 = new Thread(obj);
            t1.Start();
            Console.Read();
        }
    }
}
