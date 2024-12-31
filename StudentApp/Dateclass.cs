using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class Dateclass
    {
        public void Datemethod()
        {
            DateTime d;
            d = DateTime.Now;
            string d1 = d.ToString("dd/mm/yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(d);
            Console.WriteLine($"Day -> {d.Day}");
            Console.WriteLine($"Month -> {d.Month}");
            Console.WriteLine($"Year -> {d.Year}");

            Console.WriteLine($"Hour -> {d.Hour}");
            Console.WriteLine($"Minute -> {d.Minute}");
            Console.WriteLine($"Second -> {d.Second}");
            Console.WriteLine($"Millisecond -> {d.Millisecond}");

            Console.WriteLine($"ShortDate -> {d.ToShortDateString()}");
            Console.WriteLine($"ShortTime -> {d.ToShortTimeString()}");
            Console.WriteLine($"LongDate -> {d.ToLongDateString()}");
            Console.WriteLine($"LongTime -> {d.ToLongTimeString()}");


            Console.WriteLine($"Day of the week: {d.DayOfWeek.ToString()}");
            Console.WriteLine($"Day of the year: {d.DayOfYear}");
        }
    }
}
