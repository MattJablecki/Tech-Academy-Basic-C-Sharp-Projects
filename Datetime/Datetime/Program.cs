using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datetime
{
    class Program
    {
        static void Main()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine("The Time is currently " + now);
            Console.WriteLine("Choose a number. This will be how many hours in the future you would like to travel.");
            int hours = Convert.ToInt32(Console.ReadLine());
            DateTime future = now.AddHours(hours);
            Console.WriteLine("Whoa dude! It is now " + future + ". Somebody find Doc Brown!");
            Console.ReadLine();

        }
    }
}
