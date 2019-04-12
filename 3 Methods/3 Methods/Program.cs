using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Methods
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please input a whole number.");
            int input = Convert.ToInt32(Console.ReadLine());
            Methods.Method(input);
            Console.WriteLine("Please input a decimal.");
            float input2 = float.Parse(Console.ReadLine());
            Methods.Method(input2);
            Console.WriteLine("Please input an integer.");
            string input3 = Console.ReadLine();
            Methods.Method(input3);
            Console.ReadLine();
        }

    }
}
