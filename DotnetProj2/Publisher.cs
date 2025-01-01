using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static demodotnet.Program;

namespace demodotnet.DotnetProj2
{
    
    internal class Publisher
    {
        public event scalc myevent;
        public int x = 0, y = 0;

        public void increment()
        {
            x += 5;
            y += 6;
            int result = myevent(x, y);
            Console.WriteLine("sum is: "+result);
        }
    }
}
