using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demodotnet.DotnetProj2
{
    internal class Calculate
    {
        public void Sum(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Sum: " +  result);
        }

        public void Sub(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("Sub: " + result);
        }
    }
}
