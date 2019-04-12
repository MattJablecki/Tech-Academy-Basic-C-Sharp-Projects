using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please insert a whole number.");
            int input = Convert.ToInt32(Console.ReadLine());
            Methods.Multiply(input);
            Methods.Add(input);
            Methods.Subtract(input);
            Console.ReadLine();
        }
    }   
}
