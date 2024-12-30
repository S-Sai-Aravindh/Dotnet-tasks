using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class Cfruits
    {
        public void Choosefruit()
        {
            string[] fruits = { "Apple", "Banana", "Grapes" };
            Console.Write("Enter the fruit want to replace: ");
            string rep = Console.ReadLine();
            //string rep = "Apple";
            Console.Write("Enter the fruit to add: ");
            string nrep = Console.ReadLine();
            //string nrep = "Mango";
            int count = 0;
            for (int i = 0; i < fruits.Length; i++) 
            {
                if (fruits[i].Equals(rep, StringComparison.OrdinalIgnoreCase))
                {
                    fruits[i] = fruits[i].Replace(fruits[i], nrep);
                    break;
                }
                else 
                {
                    count += 1;
                }
            }
            if (count == 3) 
            {
                Console.WriteLine($"The {rep} fruit is not in the array");
            }


            foreach (string fruit in fruits) { Console.WriteLine(fruit); }
        }


        public void Countsent()
        {
            string input = "She sells sea shells by the sea shore";
            int count = 1;
            char letter = 'S';
            int lcount = 0;
            char[] ch = input.ToCharArray();
            foreach (char c in ch)
            {
                if(c ==  ' ')
                {
                    count += 1;
                }

                if (letter == c)
                {
                    lcount++;
                }
            }
            Console.WriteLine("The count of words: " +  count);
            Console.WriteLine("The count of letter: " + lcount);
        }
    }
}
