using System;
public class Employee
{
    public string FirstName;
    public string LastName;
    public string Email;

    public void PrintFullName()
    {
        Console.WriteLine(FirstName+" "+ LastName);
    }
    public Employee()
    {
        Console.WriteLine("ParentClass Constructor called");
    }
}

public class FullTimeEmployee:Employee
{
    public float YearlySalay;
    public FullTimeEmployee()
    {
        Console.WriteLine("ChildClass Constructor called");
    }
}

public class PartTimeEmployee : Employee//inheritance only one based class
{
    public float HourlyRate;
}

class Program
{
    public static void Main()
    {
        FullTimeEmployee FTE = new FullTimeEmployee();
        FTE.FirstName = "mike";
        FTE.LastName = "tech";
        FTE.YearlySalay = 50000;
        FTE.PrintFullName();
    }
}

//output
//ParentClass Constructor called
//ChildClass Constructor called
//mike tech
//Press any key to continue . . .


//===============================================================================================================
using System;
public class Employee
{
    public Employee()
    {
        Console.WriteLine("ParentClass Constructor called");
    }
    public Employee(string message)
    {
        Console.WriteLine(message);
    }
}

public class FullTimeEmployee:Employee
{
    public FullTimeEmployee():base("derived class controlling parent class")
    {
        Console.WriteLine("ChildClass Constructor called");
    }
}

class Program
{
    public static void Main()
    {
        FullTimeEmployee FTE = new FullTimeEmployee();
    }
}

//output
//derived class controlling parent class
//ChildClass Constructor called





