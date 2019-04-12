using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional_Parameter
{
    class Optional
    {
        public static void Method(int required)
        {
            int answer = required + 5;
            Console.WriteLine("The sum total of your input numbers plus 5 = " + answer);
        }
        public static void Method(int required, int optional)
        {
            int answer = required + optional + 5;
            Console.WriteLine("The sum total of your input numbers plus 5 = " + answer);
        }
    }
}
