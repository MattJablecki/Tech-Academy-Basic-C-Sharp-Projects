using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validAnswer = false;
            int age = 0;
            while (!validAnswer)
            {
                try
                {
                    Console.WriteLine("How old are you?");
                    validAnswer = int.TryParse(Console.ReadLine(), out age);
                    if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals");
                    else
                    {
                        DateTime now = DateTime.Now;
                        int year = now.Year;
                        int birthYear = year - age;
                        Console.WriteLine("You were born in " + birthYear);
                        Console.ReadLine();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input.");
                    Console.ReadLine();
                    return;
                }
            }
            

        }
    }
}
