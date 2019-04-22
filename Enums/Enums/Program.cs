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
            DateTime now = DateTime.Now;
            string day = now.DayOfWeek.ToString();
            try
            {
                Console.WriteLine("What day is it today?");
                string guess = Console.ReadLine();
                if (guess == day)
                {
                    Console.WriteLine("You got it!");
                    Console.ReadLine();
                }

            }
            catch(Exception)
            {
                Console.WriteLine("That is incorrect. Sorry :( ");
                Console.ReadLine();
            }


        }
    }
}
