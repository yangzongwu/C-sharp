using System;

interface ICustomer//习惯前面用I
{
    //wrong, interface members cannot have a definition
    //void Print()
    //{
    //    Console.WriteLine("hello");
    //}

    //int ID; Interfaces cannot contain fields    

    void Print();
}
interface I2//interface can interface from other interface
{

    void I2Method();
}
class Customer : ICustomer,I2 //can have multiple interface, class only have one inheritance
{
    public void I2Method()
    {
        Console.WriteLine("I2 Method");
    }

    public void Print(int Name) //deferent from ICustomer
    {
    }
    public void Print()
    {
        Console.WriteLine("Interface Print Method");
    }
}

public class Program
{
    public static void Main()
    {
        Customer C1=new Customer();
        C1.Print();//Interface Print Method
        
        ICustomer C2 = new Customer();
        //ICustomer C2 = new ICustomer(); interface can not instance
    }
}
