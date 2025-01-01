using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demodotnet.DotnetProj1
{
    internal class Task
    {
        public static string methods()
        {
            string n1 = "51";
            string n2 = "23";

            int num1 = Convert.ToInt32(n1);
            int num2 = Convert.ToInt32(n2);
            int res = 0;
            

            if(num1 > num2)
            {
                res = num1;
            }
            else if(num1 == num2)
            {
                res = num1;
            }

            else
            {
                res = num2;
            }

            string val = Convert.ToString(res);

            return val;
        }
    }
}
