using System;
using System.Collections.Generic;

    public class Program
{
    public static void Main()
    {
        List<Employee> empList = new List<Employee>();
        empList.Add(new Employee() { ID = 101, Name = "mike", Salary = 5000, Experience = 5 });
        empList.Add(new Employee() { ID = 102, Name = "ojhn", Salary = 4000, Experience = 4 });
        empList.Add(new Employee() { ID = 103, Name = "ad", Salary = 3000, Experience = 3 });
        empList.Add(new Employee() { ID = 104, Name = "mary", Salary = 6000, Experience = 6 });

        Employee.PromoteEmployee(empList);
        //mikePromoted
        //maryPromoted

        //want to reusable promote by salary?
    }
   
}

public class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
    public int Experience { get; set; }

    public static void PromoteEmployee(List<Employee> employeeList)
    {
        foreach(Employee employee in employeeList)
        {
            if(employee.Experience>=5)
            {
                Console.WriteLine(employee.Name + "Promoted");
            }
        }
    }
}
