/*
Enums are strongly typed constants.

If a program uses set of integral numbers,consider replacing them with enums.
Otherwise the program becoms less
  readable
  maintainable
*/

using System;

public class Enums
{
    public static void Main()
    {
        Customer[] customers = new Customer[3];
        customers[0] = new Customer
        {
            Name = "mark",
            Gender = 1
        };
        customers[1] = new Customer
        {
            Name = "john",
            Gender = 0
        };
        customers[2] = new Customer
        {
            Name = "mary",
            Gender = 2
        };
        foreach(Customer customer in customers)
        {
            Console.WriteLine("Name={0} && Gender={1}", customer.Name, GetGender(customer.Gender));
        }
    }
    public static string GetGender(int gender)
    {
        switch (gender)
        {
            case 0:
                return "unkonw";
            case 1:
                return "Male";
            case 2:
                return "Female";
            default:
                return "Invalid data detected";
        }
    }
}

//0-unkonw
//1-Male
//2-Female
public class Customer
{
    public string Name { get; set; }
    public int Gender { get; set; }
}
