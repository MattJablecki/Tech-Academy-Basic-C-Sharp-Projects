using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathandComparison_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ANONYMOUS INCOME COMPARISON PROGRAM");
            Console.WriteLine("Person 1");
            Console.WriteLine("What is the hourly rate for Person 1?");
            string hourly = Console.ReadLine();
            double hourlyRate = Convert.ToDouble(hourly);
            Console.WriteLine("How many hours does Person 1 work per week?");
            string hours = Console.ReadLine();
            double week = Convert.ToDouble(hours);
            Console.WriteLine("Person 2");
            Console.WriteLine("What is the hourly rate for Person 2?");
            string hourly2 = Console.ReadLine();
            double hourlyRate2 = Convert.ToDouble(hourly2);
            Console.WriteLine("How many hours does Person 2 work per week?");
            string hours2 = Console.ReadLine();
            double week2 = Convert.ToDouble(hours2);
            double annual = hourlyRate * week * 52;
            Console.WriteLine("Person 1 makes $" + annual + " a year.");
            double annual2 = hourlyRate2 * week2 * 52;
            bool trueOrFalse = annual > annual2;
            Console.WriteLine("Person 2 makes $" + annual2 + " a year.");
            Console.WriteLine("Does Person 1 make more money than Person 2?" + " " + trueOrFalse);
            Console.ReadLine();

        }
    }
}
