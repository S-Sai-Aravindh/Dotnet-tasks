using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class ListMethod
    {
        CommonMethod cm = new CommonMethod();
        public void ListMethods() 
        {
            List<int> numbers = new List<int>() { 2, 40, 10, 15, 100, 74 };
            List<int> numb = new List<int>() { 5, 2, 3 };

            numbers.Add(11);
            //numbers.Insert(2, 55);
            //numbers.InsertRange(3,);
            //numbers.AddRange(numb);
            //numbers.Sort();
            //numbers.Reverse();
            //numbers.Remove(40);
            //numbers.RemoveAt(2);

            foreach (int i in numbers) 
            {
                Console.WriteLine(i);
            }
        }
        
        List<string> fruits = new List<string>() { "Apple", "Banana", "Grapes" };
        public string ConvertTitleCase(string input)
        {
            string[] words = input.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 0)
                {
                    words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
                }
            }
            return string.Join(" ", words);
        }
        public void ShowArray()
        {
            Console.WriteLine("The array of fruits:");
            foreach (string s in fruits)
            {
                Console.WriteLine(ConvertTitleCase(s));
            }
        }

        public void Addfruit(string fruit)
        {
            
            int pos = -1;

            for (int i = 0; i < fruits.Count; i++)
            {
                if (fruits[i].Equals(fruit, StringComparison.OrdinalIgnoreCase))
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
                fruits.Add(fruit);
                Console.WriteLine($"Your array after adding : {fruit}");

            }
            ShowArray();
        }

        public void UpdateFruit()
        {
            //Console.Write("Enter the fruit want to replace: ");
            string rep = cm.UserInput("Enter the fruit want to replace: ");
            int count = 0;
            //Console.Write("Enter the fruit to add: ");
            string nrep = cm.UserInput("Enter the fruit to add: ");

            int pos = -1;

            for (int i = 0; i < fruits.Count; i++)
            {
                if (fruits[i].Equals(nrep, StringComparison.OrdinalIgnoreCase))
                {
                    pos = i;
                    break;
                }
            }

            if (pos >= 0)
            {
                Console.WriteLine("Fruit is present in the array");
                
            }
            else
            {
                for (int i = 0; i < fruits.Count; i++)
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
                if (count == fruits.Count)
                {
                    Console.WriteLine($"The {rep} fruit is not in the array");
                }
                Console.WriteLine("The array after update:");
            }
            
            ShowArray();
        }

        public void Deletefruit()
        {
            //Console.Write("Enter the fruit want to delete: ");
            string del = cm.UserInput("Enter the fruit want to delete: ");
            int count = 0;
            for (int i = 0;i< fruits.Count; i++)
            {
                if(fruits[i].Equals(del, StringComparison.OrdinalIgnoreCase))
                {
                    fruits.RemoveAt(i);
                }
                else
                {
                    count += 1;
                }
            }
            if (count == fruits.Count)
            {
                Console.WriteLine("The fruit is not in the array");
            }
            else
            {
                Console.WriteLine("The array after delete");
            }
            
            ShowArray();

        }

        public void FruitsMenu()
        {
            Console.WriteLine("********** Fruits Menu **********");
            Console.WriteLine("1. Display Fruits");
            Console.WriteLine("2. Add Fruit");
            Console.WriteLine("3. Update Fruit");
            Console.WriteLine("4. Delete Fruit");
            Console.WriteLine("5. Exit Menu");
            Console.Write("Enter your choice 1 - 5: ");
            int ch = Convert.ToInt32(Console.ReadLine());
            

            switch (ch)
            {
                case 1:
                    ShowArray();
                    FruitsMenu();
                    break;
                case 2:
                    //Console.Write("Enter the fruit you want to add: ");
                    //string fruit = Console.ReadLine();
                    string fruit = cm.UserInput("Enter the fruit you want to add: ");
                    Addfruit(fruit);
                    FruitsMenu();
                    break;
                case 3:
                    UpdateFruit();
                    FruitsMenu();
                    break;
                case 4:
                    Deletefruit();
                    FruitsMenu();
                    break;
                case 5:
                    break;
                default:
                    FruitsMenu();
                    break;
            }
        }
    }
}
