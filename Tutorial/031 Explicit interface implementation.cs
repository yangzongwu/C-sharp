using System;

interface I1
{
    void InterfaceMethod();
}
interface I2
{
    void InterfaceMethod();
}

public class Program : I1,I2
{
    public void InterfaceMethod()
    {
        Console.WriteLine("I1 Interface Method");//I1?I2 implement both
    }
    public static void Main()
    {
        Program P = new Program();
        P.InterfaceMethod();//I1 Interface Method
        ((I1)P).InterfaceMethod();//I1 Interface Method
        ((I2)P).InterfaceMethod();//I1 Interface Method
    }
}


//==========================================================================================
using System;

interface I1
{
    void InterfaceMethod();
}
interface I2
{
    void InterfaceMethod();
}

public class Program : I1,I2
{
    void I1.InterfaceMethod()
    {
        Console.WriteLine("I1 Interface Method");//I1 implement both
    }
    void I2.InterfaceMethod()
    {
        Console.WriteLine("I1 Interface Method");//I2 implement both
    }
    public static void Main()
    {
        Program P = new Program();
        //P.InterfaceMethod() can not like this
        ((I1)P).InterfaceMethod();//I1 Interface Method
        ((I2)P).InterfaceMethod();//I2 Interface Method
    }
}

//=================================================================================
using System;

interface I1
{
    void InterfaceMethod();
}
interface I2
{
    void InterfaceMethod();
}

public class Program : I1,I2
{
    void I1.InterfaceMethod()
    {
        Console.WriteLine("I1 Interface Method");//I1 implement both
    }
    void I2.InterfaceMethod()
    {
        Console.WriteLine("I1 Interface Method");//I2 implement both
    }
    public static void Main()
    {
        I1 i1 = new Program();
        I2 i2 = new Program();
        i1.InterfaceMethod();
        i2.InterfaceMethod();
    }
}

//========================================default=============================================
using System;

interface I1
{
    void InterfaceMethod();
}
interface I2
{
    void InterfaceMethod();
}

public class Program : I1,I2
{
    public void InterfaceMethod()
    {
        Console.WriteLine("I1 Interface Method");//I1 implement both
    }
    void I2.InterfaceMethod()
    {
        Console.WriteLine("I1 Interface Method");//I2 implement both
    }
    public static void Main()
    {
        Program P = new Program();
        P.InterfaceMethod();//I1 Interface Method
        ((I2)P).InterfaceMethod();//I2 Interface Method
    }
}

