using System;
class Customer
{
    string _firstName;
    string _lastName;

    public Customer() : 
        this("No FirstName Provide", "No LastName Provide")
    {
    }

    public Customer(string FirstName, string LastName)
    {
        this._firstName = FirstName;
        this._lastName = LastName;
    }

    public void PrintFullName()
    {
        Console.WriteLine("Full Name={0}", this._firstName + " " + this._lastName);
    }
    ~Customer()//destructor
    {
        // Clean up code
    }
}
namespace part1_ConsoleApp1
{
    class Program
    {
        public static void Main()
        {
            Customer C1 = new Customer();
            C1.PrintFullName();//Full Name=No FirstName Provide No LastName Provide
            Customer C2 = new Customer("mike","y");
            C2.PrintFullName();//Full Name=mike y
        }
 
    }
}

