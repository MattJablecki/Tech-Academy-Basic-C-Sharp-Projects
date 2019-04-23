using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    public class Program
    {
        public static void Main()
        {
            List<Employee> employeesList = new List<Employee>();
            employeesList.Add(new Employee()
            { FirstName = "Joe", LastName = "Smith", ID = 1 });
            employeesList.Add(new Employee()
            { FirstName = "Joe", LastName = "Rogan", ID = 2 });
            employeesList.Add(new Employee()
            { FirstName = "Joe", LastName = "Jackson", ID = 3 });
            employeesList.Add(new Employee()
            { FirstName = "Joe", LastName = "Esposito", ID = 4 });
            employeesList.Add(new Employee()
            { FirstName = "Steve", LastName = "Stevens", ID = 5 });
            employeesList.Add(new Employee()
            { FirstName = "Lisa", LastName = "Simpson", ID = 6 });
            employeesList.Add(new Employee()
            { FirstName = "Mary", LastName = "Murphy", ID = 7 });
            employeesList.Add(new Employee()
            { FirstName = "Kelly", LastName = "Kapowski", ID = 8 });
            employeesList.Add(new Employee()
            { FirstName = "Cersei", LastName = "Lannister", ID = 9 });
            employeesList.Add(new Employee()
            { FirstName = "Jean", LastName = "Bobean", ID = 10 });



            foreach (var Employee in employeesList)
            {
                List<Employee> joeList = new List<Employee>();
                if (Employee.FirstName == "Joe")
                {
                    joeList.Add(Employee);
                }
            }

            List<Employee> joes = new List<Employee> joes.Add(x =>, Employee.FirstName("Joe"));

            List<Employee> ids = new List<Employee> ids.Add(x =>, Employee.ID(id > 5));

        }

        


    }
}
