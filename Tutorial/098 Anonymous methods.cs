Anonymous method is a method without a name.

//step1 : create a method whose signature mathes with the signature of Predicate<Employee> delegate
Private static bool FindEmployee(Employee Emp){
  return Emp.ID==102;
}

//step2:Create an instance of Predicate<Employee> delegate and pass the 
//method name as an argument to the delegate constructor
Predicate<Employee> predicateEmployee=new Predicate<Employee>(FindEmployee);

//step3:Now pass the delegate instance as the argement for Find() method
Employee employee=listEmployees.Find(x=>predicateEmployee(x));
Console.WriteLine("ID={0},Name {1}",employee.ID,employee.Name);

//Anonymous method is being passed as an argument to the Find() method 
//This anonymous method replaces the need for step 1,2,3
employee=listEmployees.Find(delegate(Employee x){return x.ID==102;});
Console.WriteLine("ID={0},Name {1}",employee.ID,employee.Name);



//===============================================================================================================
using System;
using System.Collections.Generic;

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
            ////step2
            //Predicate<Employee> employeePredicate = new Predicate<Employee>(FindEmployee);

            ////step3:
            //Employee employee=listemployees.Find(emp => employeePredicate(emp));
            //Console.WriteLine("ID={0},Name {1}", employee.ID, employee.Name);
            Employee employee = listemployees.Find(delegate (Employee emp)
              {
                  return emp.ID == 102;
              }
              );
            Console.WriteLine("ID={0},Name {1}", employee.ID, employee.Name);
        }

        ////step1 
        //public static bool FindEmployee(Employee emp)
        //{
        //    return emp.ID == 102;
        //}

        public class Employee
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }

    }
}
