using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TplNetwork
{
    class Thread5
    {
        public void Demo()
        {
            lock (this)
            {
                Console.Write("C Sharp is ");
                Thread.Sleep(5000);
                Console.WriteLine("a object oriented language ");
            }
        }
        static void Main(string[] args)
        {
            Thread5 obj1 = new Thread5();
            Thread T1 = new Thread(obj1.Demo);
            Thread T2 =new Thread(obj1.Demo);
            Thread T3 = new Thread(obj1.Demo);
            T1.Start();T2.Start();T3.Start();
            Console.Read();

        }


    }
}
