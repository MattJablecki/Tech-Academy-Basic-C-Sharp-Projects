using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More_With_Methods
{
    class Program
    {
        public static void Main()
        {
            int num1 = 3;
            int num2 = 5;
            Number.Drill (num1, num2);
        }
    }
    class Number
    {
        public static void Drill (int parameter1, int parameter2)
        {
            int answer = parameter1 + 1;
            Console.WriteLine(answer);
            Console.WriteLine(parameter2);
            Console.ReadLine();
        }

    }
}
