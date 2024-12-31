using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace StudentApp
{
    internal class StringFunction
    {
        string fullname = "Sai Aravindh ";
        string greetmsg = "Good Morning";
        string city1 = "Chennai";
        string city2 = "chennai";

        public void showStringMethod()
        {
            Console.WriteLine("Actual string: " + fullname);
            Console.WriteLine("Actual string: " + fullname.Trim ());
            Console.WriteLine(fullname.ToLower());
            Console.WriteLine(fullname.ToUpper());
            Console.WriteLine(fullname[0]);
            Console.WriteLine(fullname.Substring(1,3));
            Console.WriteLine(fullname.Remove(1,3));
            Console.WriteLine(fullname.StartsWith("Sai"));
            Console.WriteLine(fullname.EndsWith("Sai"));
            Console.WriteLine(fullname.Contains("Ara"));
            //Console.WriteLine("Equal method: "+city1.Equals(city2.StringComparison.))
            Console.WriteLine(fullname.Equals(greetmsg));
            Console.WriteLine(fullname.IndexOf(" "));
            Console.WriteLine(fullname.LastIndexOf(" "));
            Console.WriteLine(string.Format("Good Afternoon {0}",fullname));
            char[] chrs = city1.ToCharArray();
            foreach(char c in chrs) Console.WriteLine(c);
            string[] nameArr = fullname.Split(" ");
            foreach(string name in nameArr) Console.WriteLine(name);
            Console.WriteLine(string.Join(" ",nameArr));
        }

        public void stringinput()
        {
            string name = Console.ReadLine();
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            string titleCaseName = textInfo.ToTitleCase(name.ToLower());
            Console.WriteLine(titleCaseName);

            string city = Console.ReadLine();

            char[] charArray = city.ToCharArray();
            Array.Reverse(charArray);
            string str = new string(charArray);

            Console.WriteLine(str);

            string titleCase = ConvertTitleCase(name);
            Console.WriteLine(titleCase);
        }

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
    }
}
