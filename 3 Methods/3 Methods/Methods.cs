using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Methods
{
    public class Methods
    {
        public static void Method(int Integer)
        {
            int answer = Integer + 1;
            Console.WriteLine(Integer + " plus 1 = " + answer);
        }
        public static void Method(float Float)
        {
            float answer2 = Float * 5;
            Console.WriteLine(Float + " times 5 = " + answer2);
        }
        public static void Method(string String)
        {
            try
            {
                int number = Convert.ToInt32(String);
                int answer3 = number - 3;
                Console.WriteLine(number + " minus 3 = " + answer3);
            }
            catch(FormatException)
            {
                Console.WriteLine("Invalid.");
                return;
            }
        }
    }
}
