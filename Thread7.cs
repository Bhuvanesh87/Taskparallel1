using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TplNetwork
{
    class Thread7
    {
        public static long count=0;
        public static void IncreamentCount1()
        {
           for(int i=1;i<100000;i++)
              count += 1;
            Console.WriteLine("The Increamentcount1 value is  : " + count);
        }
        public static void IncreamentCount2()
        {
            for(int i = 1; i < 100000; i++)
            count += 1;
            Console.WriteLine("The Increamentcount2 value is  : " + count);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main thread starts");
            Stopwatch s1 = new Stopwatch();
            Stopwatch s2 = new Stopwatch();
            Thread t1 = new Thread(IncreamentCount1);
            Thread t2 = new Thread(IncreamentCount2);
            s1.Start();
            IncreamentCount1();
            IncreamentCount2();
            s1.Stop();
            s2.Start();
            t1.Start();
            t2.Start();
            s2.Stop();                   
            t1.Join();
            t2.Join();
            Console.WriteLine("Time taken for single threaded model :" +s1.ElapsedMilliseconds);
            Console.WriteLine("Time taken for Multithreaded  threaded model :" +s2.ElapsedMilliseconds);
            Console.WriteLine("Main thread ends");
            Console.Read();
        }
    }
}
