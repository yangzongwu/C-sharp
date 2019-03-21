//three ways to use hiding method
using System;
public class Employee
{
    public string FirstName;
    public string LastName;

    public void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }
}
public class PartTimeEmployee : Employee
{
    public new void PrintFullName()//add new hide the base class member
    {
        //Console.WriteLine(FirstName + " " + LastName+"-contactor");
        //1.base.PrintFullName();//if hide, use base to use class member
    }
}
public class FullTimeEmployee : Employee
{
   
}


class Program
{
    public static void Main()
    {
        FullTimeEmployee FTE = new FullTimeEmployee();
        FTE.FirstName = "FullTime";
        FTE.LastName = "Employee";
        FTE.PrintFullName();
        PartTimeEmployee PTE = new PartTimeEmployee();
        PTE.FirstName = "PartTime";
        PTE.LastName = "Employee";
        PTE.PrintFullName();
        //2.((Employee)PTE).PrintFullName();
        //3.Employee PTE1 = new PartTimeEmployee();
        //3.PTE1.PrintFullName();
    }
}




