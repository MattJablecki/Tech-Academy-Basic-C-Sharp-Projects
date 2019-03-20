using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Matt. ");
            sb.Append("I am a student at the Tech Academy.");
            sb.Append("\nI was told to build this paragraph with Stringbuilder.");
            sb.Append("\nLet's see if it worked... ");

            Console.WriteLine(sb);

            string it = ("\n\nIt ");
            string looks = ("looks ");
            string like = ("like it worked!");
            string sentence = (it + looks + like);

            Console.WriteLine(sentence);

            string hooray = ("\n\nhooray");
            hooray = hooray.ToUpper();

            Console.WriteLine(hooray);


            Console.ReadLine();
        }
    }
}
