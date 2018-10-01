using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TplNetwork
{
    class Thread6
    {
        public static long count1,count2;
        public static void IncreamentCount1()
         {
                while(true)
                count1 += 1;
         }
        public static void IncreamentCount2()
        {
            while (true)
            count2 += 1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main thread starts");
            Thread6 t6 = new Thread6();
            Thread t1 = new Thread(IncreamentCount1);
            Thread t2 = new Thread(IncreamentCount2);
            t1.Start();
            t2.Start();
            t1.Priority = ThreadPriority.Lowest;
            t2.Priority = ThreadPriority.Highest;

            Console.WriteLine("Main thread going to sleep");
            Thread.Sleep(5000);
            t1.Abort();
            t2.Abort();
            t1.Join();
            //t2.Join();
            Console.WriteLine("Thread1 : " +count1 );
            Console.WriteLine("Thread2 : " +count2 );
            Console.WriteLine("Main thread ends");
            Console.Read();
        }
    }
}
