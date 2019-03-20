using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number.");
            double input = Convert.ToDouble(Console.ReadLine());
            double total = input * 50;
            Console.WriteLine("Your number multiplied by 50 = " + total.ToString());
            Console.ReadLine();

            Console.WriteLine("Please input another number.");
            double input2 = Convert.ToDouble(Console.ReadLine());
            double total2 = input2 + 25;
            Console.WriteLine("Your number plus 25 = " + total2.ToString());
            Console.ReadLine();

            Console.WriteLine("Please input another number.");
            double input3 = Convert.ToDouble(Console.ReadLine());
            double total3 = input3 / 12.5;
            Console.WriteLine("Your number divided by 12.5 = " + total3.ToString());
            Console.ReadLine();

            Console.WriteLine("Please input another number.");
            double input4 = Convert.ToDouble(Console.ReadLine());
            bool trueOrFalse = input4 > 50;
            Console.WriteLine("True or false, your number is greater than 50?" + " " + trueOrFalse);
            Console.ReadLine();

            Console.WriteLine("Please input another number.");
            double input5 = Convert.ToDouble(Console.ReadLine());
            double remainder = input5 % 7.0;
            Console.WriteLine("Your number, divided by 7, has a remainder of " + remainder.ToString());
            Console.ReadLine();
        }
    }
}
