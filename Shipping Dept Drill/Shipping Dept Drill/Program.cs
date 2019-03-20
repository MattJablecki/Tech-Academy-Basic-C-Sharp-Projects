using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping_Dept_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight: ");
            string weight = Console.ReadLine();
            double pWeight = Convert.ToDouble(weight);
            if (pWeight > 50)
            {
                Console.WriteLine("Package too heavy to shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please enter the package width:");
                string width = Console.ReadLine();
                double pWidth = Convert.ToDouble(width);
                Console.WriteLine("Please enter the package height:");
                string height = Console.ReadLine();
                double pHeight = Convert.ToDouble(height);
                Console.WriteLine("Please enter the package length:");
                string length = Console.ReadLine();
                double pLength = Convert.ToDouble(length);
                if (pWidth + pHeight + pLength > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                    Console.ReadLine();
                }
                else
                {
                    double sum = pWidth + pHeight + pLength;
                    double x = sum * pWeight;
                    decimal y = Convert.ToDecimal(x);
                    decimal quote = y / 100;
                    Console.WriteLine("Your estimated total for shipping this package is:" + quote.ToString("C"));
                    Console.ReadLine();
                }


            }
        }
    }
}
