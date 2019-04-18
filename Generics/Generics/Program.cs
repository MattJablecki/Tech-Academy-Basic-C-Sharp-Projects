using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Program
    {
        public static void Main()
        {
            Employee<string> employee = new Employee<string> ();
            employee.Things;
            Employee<int> ID = new Employee<int>();
            ID.Things;            
        }
    }
}
