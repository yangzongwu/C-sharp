Func<T,TResult> eg: Func<Employee,string>
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

            //Func<Employee, string> selector = employee => "Name= " + employee.Name;
            //IEnumerable<String> names = listemployees.Select(selector);
            IEnumerable<String> names = listemployees.Select(employee => "Name= " + employee.Name);
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

        public class Employee
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }

    }
}
//===========================================================
public static void Main()
{
  Func<int,int,string> funcDelegate =(firstNumber,secondNumber)=>"Sum = "+(firstNumber+secondNumber).ToString();
  string result=funcDelegate(10,20);
  Console.WriteLine(result);
}
