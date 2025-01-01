using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demodotnet.DotnetProj2
{
    internal class Subscriber
    {
        public void doWork()
        {
            Publisher p = new Publisher();
            //p.myevent += delegate (int a, int b)
            //{
            //    int res = a + b;
            //    Console.WriteLine("Sum is : " + res);
            //};
            p.myevent += (a, b) => (a + b);
            p.increment();
        }
    }
}
