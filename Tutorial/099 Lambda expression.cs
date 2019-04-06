using anonymous method
Employee employee = listemployees.Find(delegate (Employee emp){return emp.ID == 102;}

using lambda expression
Employee employee = listemployees.Find(Emp=>Emp.ID==102);

not required
Employee employee = listemployees.Find((Employee Emp)=>Emp.ID==102);

using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> listemployees = new List<Employee>()
            {
                new Employee{ID=101,Name="Mark"},
                new Employee{ID=102,Name="John"},
                new Employee{ID=103,Name="Mary"},
            };

            Employee employee = listemployees.Find(X => X.ID == 102);
            Console.WriteLine("ID={0},Name {1}", employee.ID, employee.Name);

            int count = listemployees.Count(x => x.Name.StartsWith('M'));
            Console.WriteLine("count="+count);
        }

        public class Employee
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }

    }
}
