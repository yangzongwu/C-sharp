/*
there are 5 different access modifiers:
1.Private
2.Protected
3.Internal
4.Protected Internal
5.Public

Private members are available only with the containing type
Public members are available any where
Protected members are available, with in the containing type and to the type 
that derive from the containing type

*/
using System;

public class Customer
{
    private int _id;// only availabe within Customer class;
    public int ID
    {
        get { return _id; }
        set { _id = value; }
    }
}
public class Mainclass
{
    private static void Main()
    {
        Customer C1 = new Customer();
        //C1._id; wrong
        Console.WriteLine(C1.ID);
    }
}
//=================================================================================
using System;

public class Customer
{
    protected int id;
}
public class CorporateCustomer : Customer
{
    public void PrintId()
    {
        CorporateCustomer CC = new CorporateCustomer();
        CC.id = 101;

        base.id=1;
        this.id = 1;
    }
}
public class Mainclass
{
    private static void Main()
    {
        Customer C1 = new Customer();
        //Console.Write(C1.id);//wrong
        //base.id;//wrong
    }
}
