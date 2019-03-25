//like classes structs can have
//1.Priavte Fields
//2.Public Properties
//3.Constructors
//4.Mehtods

using System;

public struct Customer
{
    private int _id;
    private string _name;
    public int ID
    {
        get { return this._id; }
        set { this._id = value; }
    }
    public string Name
    {
        get { return this._name; }
        set { this._name = value; }
    }

    public Customer(int Id, string Name)
    {
        this._id = Id;
        this._name = Name;
    }
    public void PrintDetails()
    {
        Console.WriteLine("id={0} && Name={1}", this._id, this._name);
    }
}

public class Program
{
    public static void Main()
    {
        Customer C1 = new Customer(101, "nmike");
        C1.PrintDetails();//id=101 && Name=nmike
        Customer C2 = new Customer();
        C2.PrintDetails();//id=0 && Name=
        C2.ID = 102;
        C2.Name = "john";
        C2.PrintDetails();//id=102 && Name=john
        Customer C3 = new Customer()
        {
            ID = 103,
            Name = "hh"
        };
        C3.PrintDetails();//id=103 && Name=hh
    }
}
