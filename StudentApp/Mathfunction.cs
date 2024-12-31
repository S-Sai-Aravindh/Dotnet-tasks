using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class Mathfunction
    {
        public void mathmethod()
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            double num3 = Convert.ToDouble(Console.ReadLine());
            double num4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(Math.Min(num1, num2));
            Console.WriteLine(Math.Max(num1, num2));
            Console.WriteLine(Math.Floor(num3));
            Console.WriteLine(Math.Ceiling(num3));
            Console.WriteLine(Math.Pow(num1, num2));
            Console.WriteLine(Math.Sqrt(num1));
            Console.WriteLine(Math.Abs(num4));
            Console.WriteLine(Math.Round(num3));
        }

        public void smallarr()
        {
            int[] numbers = new int[5];
            

            for (int i = 0; i < 5; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            int max = numbers[0];
            int min = numbers[0];
            for(int i =0;i < 5; i++)
            {
                max = Math.Max(max, numbers[i]);
                min = Math.Min(min, numbers[i]);
            }
            Console.WriteLine("Smallest number(with math): "+min);
            Console.WriteLine("Largest number(with math): " + max);

            int s = numbers[0];
            int l = numbers[0];
            for(int i = 1; i < 5; i++)
            {
                if (s > numbers[i])
                {
                    s= numbers[i];
                }

                if (l < numbers[i]) 
                {
                    l = numbers[i];
                }
            }

            Console.WriteLine("Smallest number(without math): " + s);
            Console.WriteLine("Largest number(without math): " + l);
        }
    }
}
