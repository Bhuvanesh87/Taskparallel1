using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TplNetwork
{
    class Tpl1
    {
        static void Dowork(int id,int sleep)
        {
            Console.WriteLine(" Task {0} is begining ....", id);
            Thread.Sleep(3000);
            Console.WriteLine("Task {0} is ending ......", id);
            
        }
        static void Main(string[] args)
        {
            Task t1=new Task(() =>  Dowork(1, 1000));
            t1.Start();
            Task t2 = new Task(() => Dowork(2, 3000));
            t2.Start();
            Task t3 = new Task(() => Dowork(3, 1500));
            t3.Start();
            Console.Read();
        }
    }
}
