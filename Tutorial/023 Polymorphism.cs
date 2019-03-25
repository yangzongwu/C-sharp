using System;
public class Employee
{
    public string FirstName="FN";
    public string LastName="LN";

    public virtual void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }
}
public class PartTimeEmployee : Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName+"-Part Time");
    }
}
public class FullTimeEmployee : Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + "-Full Time");
    }
}
public class TemporaryEmployee : Employee
{
    //public void PrintFullName()
    //{
    //    Console.WriteLine(FirstName + " " + LastName + "-Temporary");
    //}
}

class Program
{
    public static void Main()
    {
        Employee[] employees = new Employee[4];
        employees[0] = new Employee();
        employees[1] = new PartTimeEmployee();
        employees[2] = new FullTimeEmployee();
        employees[3] = new TemporaryEmployee();
        foreach(Employee e in employees)
        {
            e.PrintFullName();
        }
        //FN LN
        //FN LN-Part Time
        //FN LN - Full Time
        //FN LN

    }
}




