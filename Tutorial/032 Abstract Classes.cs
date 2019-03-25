/*  
 The abstrack keyword is used to create abstract classes.
 An abstrack class is incomplete and hence cannot be instantiated
 An abstract class can only be used as base class.
 An abstract class cannoto be sealed
 An abstract class may contain abstract members(methods,properties,indexers,and events),but not mandatory.
 A non-abstract class derived from an abstract class must provide implementations fro all inherited abstract members
 */
 
 using System;

public abstract class Customer
{
    public abstract void Print();
    public void method1()
    {
        Console.WriteLine("Print");
    }
    
}

//public abstract class Program:Customer
//{
//    public static void Main()
//    {

//    }
//}
public class Program : Customer
{
    public override void Print()
    {
        Console.WriteLine("print method");
    }
    public static void Main()
    {
        Program P = new Program();
        P.Print();
    }
}
