using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Methods
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please input a whole number.");
            int input = Convert.ToInt32(Console.ReadLine());
            Method.Divide(input);
        }
    }
}
