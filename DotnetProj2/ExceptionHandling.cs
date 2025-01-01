using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demodotnet.DotnetProj2
{
    internal class ExceptionHandling
    {
        public void ExceptionMethod()
        {
            try
            {
                Console.Write("Enter first number: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter second number: ");
                int b = Convert.ToInt32(Console.ReadLine());
                int c = a / b;
                Console.WriteLine("Quotient is " + c);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finished");
            }
        }
    }
}
