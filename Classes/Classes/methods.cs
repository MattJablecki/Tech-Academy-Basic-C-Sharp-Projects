using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Methods
    {
        public static void Multiply(int parameter)
        {
            int answer1 = parameter * 2;
            Console.WriteLine("Your number multiplied by 2 = " + answer1);

        }
        public static void Add(int parameter)
        {
            int answer2 = parameter + 5;
            Console.WriteLine("Your number plus 5 = " + answer2);
        }
        public static  void Subtract(int parameter)
        {
            int answer3 = parameter - 1;
            Console.WriteLine("Your number minus 1 = " + answer3);
        }
    }
}
