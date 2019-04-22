using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVar
{
    class Program
    {
        public static void Main(string[] args)
        {
            const string Company = "The ACME Factory";
            var Year = 2019;
            Employee employee1 = new Employee(5023, "Joe Jackson");
            Employee employee2 = new Employee("Lisa Turtle");
            Console.WriteLine("Welcome to " + Company + ". \nEstablished in " + Year + ", we have two great employees we'd love to recognize. \n" + employee1.name + " & " + employee2.name + "\nThanks for being great employees!");
            Console.ReadLine();
        }

    }
}
