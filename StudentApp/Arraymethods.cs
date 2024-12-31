using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class Arraymethods
    {
        public void showsArrayfunction()
        {
            int[] numbers = { 10, 200, 150, 40 ,25 };
            int[] newnum = new int[5];
            Console.WriteLine(Array.IndexOf(numbers, 200));
            //Array.Sort(numbers);
            Console.WriteLine(Array.BinarySearch(numbers,40));
            numbers.CopyTo(newnum,0);
            Array.Resize(ref newnum , 7);
            newnum[5] = 34;
            newnum[6] = 56;
            Array.Clear(newnum,4, 2);
            Array.Reverse(newnum);
            Console.WriteLine("#####");
            foreach(int i in newnum)
            {
                Console.WriteLine(i);
            }


        }

        public void Arraypresent()
        {
            int[] numbers = { 20, 30, 100, 120, 40 };

            int num = Convert.ToInt32(Console.ReadLine());

            int pos = Array.IndexOf(numbers, num);

            if (pos >= 0)
            {
                Console.WriteLine("The value is in position: " + (pos + 1));
            }

            else
            {
                Console.WriteLine("The value is not present");
            }

            Console.WriteLine("The array is");
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

        }

        public void ShowArray() 
        {
            string[] fruits = { "Apple", "Banana", "Grapes" };
            foreach (string s in fruits)
            {
                Console.WriteLine(s);
            }
        }

        public void StringArraypresent()
        {
            string[] fruits = { "Apple", "Banana", "Grapes" };
            Console.Write("Enter a fruit to find: ");
            string find = Console.ReadLine();
            int pos = -1;

            for (int i = 0; i < fruits.Length; i++)
            {
                if (fruits[i].Equals(find, StringComparison.OrdinalIgnoreCase))
                {
                    pos = i;
                    break;
                }
            }

            if (pos >= 0)
            {
                Console.WriteLine("Element is present");
            }
            else
            {
                Console.WriteLine("Element is not present");
            }

            Console.WriteLine("The array is");
          

            foreach(string s in fruits)
            {
                Console.WriteLine(s);
            }
        }


        public void FruitsMenu()
        {
            Console.WriteLine("********** Fruits Menu **********");
            Console.WriteLine("1. Display Menu");
            Console.WriteLine("2. Find Fruit");
            Console.WriteLine("3. Exit Menu");
            Console.Write("Enter your choice 1 or 2 or 3: ");
            int ch = Convert.ToInt32(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    ShowArray();
                    FruitsMenu();
                    break;
                case 2:
                    StringArraypresent();
                    FruitsMenu();
                    break;
                case 3:
                    break;
                default:
                    FruitsMenu();
                    break;
            }
        }
    }
}
