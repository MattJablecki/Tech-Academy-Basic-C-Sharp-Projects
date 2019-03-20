using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            bool entry = false;
            while (entry == false)
            {
                Console.Write("Please enter your user name: ");
                string userName = Console.ReadLine();

                if (userName == "admin")
                {
                    Console.WriteLine("Welcome admin. So good to see you again!");
                    entry = true;
                    Console.WriteLine("Please enter your 4 digit pin");
                    ushort pin = Convert.ToUInt16(Console.ReadLine());
                    bool correct = pin == 1234;

                    do
                    {
                        switch (pin)
                        {
                            case 1234:
                                Console.WriteLine("Pin accepted. You have now have access to the nuclear codes.");
                                correct = true;
                                break;
                            default:
                                Console.WriteLine("Incorrect Pin. Try again.");
                                pin = Convert.ToUInt16(Console.ReadLine());
                                break;
                        }
                    }
                    while (!correct);

                    Console.Read();
                }
                else
                {
                    Console.WriteLine("Unrecognized user.");
                    entry = false;
                }
            }
            Console.Read();
        }
    }
}
