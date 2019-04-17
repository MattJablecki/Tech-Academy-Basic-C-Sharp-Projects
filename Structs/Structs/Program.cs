using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    public class Program
    {
        public static void Main()
        {
            Number number = new Number();
            number.Amount = 5.5M;
            Console.WriteLine(number.Amount);
            Console.ReadLine();
        }
    }
}
