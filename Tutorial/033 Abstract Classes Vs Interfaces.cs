//==================================================================================================================
//Abstract classed can have implementations for some of this members(Methods),
//but the interface can't have implementation for any of its members
public abstract class Customer
{
    public void Print()
    {
        Console.WriteLine("Print");
    }
}
public interface ICustomer
{
    void Print();
}

//==================================================================================================================
//Interfaces cannot have fields where as an abstract class can have fields
public abstract class Customer
{
    int ID;
    public void Print()
    {
        Console.WriteLine("Print");
    }
}

public interface ICustomer
{
    void Print();
}

//==================================================================================================================
//An interface can inherit from another interface only and cannot inherit from an abstract class.
//where as an abstract class can inherit from another abstract class or another interface

//==================================================================================================================
//A class can inherit from multiple interfaces at the same time, where as a class cannot inherit 
//from multiple classed at the same time.

//==================================================================================================================
 //abstract class members can have access modifiers where as interface members cannot have access modifiers.
