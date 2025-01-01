using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demodotnet.DotnetProj2
{
    internal class Counter
    {
        public int counter = 1;
        public class Increment 
        {
            Counter c = new Counter();
            public void doIncrement()
            {
                c.counter += 5;
                Console.WriteLine(c.counter);
                Console.WriteLine("601 to 627 & 417 Linq fully Self study");
            }
        }
    }
}
