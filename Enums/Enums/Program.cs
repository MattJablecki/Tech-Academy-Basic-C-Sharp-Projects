using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        public enum DayOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        private static void Main()
        {
            try
            {
                Console.WriteLine("What day is it?");
                string day = Console.ReadLine();
                DayOfTheWeek dayOfTheWeek = (DayOfTheWeek)Enum.Parse(typeof(DayOfTheWeek), day);
                Console.WriteLine("Nice.");
                Console.ReadLine();
            }
            catch(Exception)
            {
                Console.WriteLine("That is invalid. Sorry :( ");
                Console.ReadLine();
            }


        }
    }
}
