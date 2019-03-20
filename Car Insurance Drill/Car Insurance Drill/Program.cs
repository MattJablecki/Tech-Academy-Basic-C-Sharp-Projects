using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Insurance_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Tech Academy Insurance Company!");
            Console.WriteLine("Let's get some basic information to see if you qualify!");
            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();
            int agex = Convert.ToInt32(age);
            Console.WriteLine("Have you ever had a DUI? Answer true of false.");
            string trueOrFalse = Console.ReadLine();
            bool tof = Convert.ToBoolean(trueOrFalse);
            Console.WriteLine("How many speeding tickets do you have?");
            string tickets = Console.ReadLine();
            int sTickets = Convert.ToInt32(tickets);
            Console.WriteLine("Are you qualified?");
            bool qualified = (agex > 15 && tof == false && sTickets <= 3);
            Console.WriteLine(qualified);
            Console.ReadLine();
        }
    }
}
