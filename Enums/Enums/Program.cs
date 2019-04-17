using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current day of the week.");
            string day = Console.ReadLine();
            Enum.TryParse<DaysOfTheWeek>(day, out DaysOfTheWeek daysOfTheWeek);
            Console.WriteLine("Yes, " + daysOfTheWeek + " is valid");
            Console.ReadLine();
        }
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
