using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TplNetwork
{
    class Tpl2
    {
        static void Main(string[] args)
        {
            int[] x = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Parallel.For(0, 10, i =>
                                     {
                                         Console.WriteLine("i =  : " + i);
                                         Thread.Sleep(2000);
                                     }  
                         );
        }        
    }
}
