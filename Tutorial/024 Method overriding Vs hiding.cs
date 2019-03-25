//overriding 
//in method overriding a base class reference variable pointing to a child class
//object, will invoke the overridden method in the child class

using System;
public class BaseClass
{
    public virtual void Print()
    {
        Console.WriteLine("I am a Base Class Print Method");
    }
}
public class DerivedClass:BaseClass
{
    public override void Print()
    {
        Console.WriteLine("I am a Derived Class Print Method");
    }
}

class Program
{
    public static void Main()
    {
        BaseClass B = new DerivedClass();
        B.Print();//I am a Derived Class Print Method
    }
}


//hiding
// in menthod hidding a base class reference variable pointing to a child class
//object, will invoke the hidden method in the base class

using System;
public class BaseClass
{
    public virtual void Print()
    {
        Console.WriteLine("I am a Base Class Print Method");
    }
}
public class DerivedClass:BaseClass
{
    public new void Print()
    {
        Console.WriteLine("I am a Derived Class Print Method");
    }
}

class Program
{
    public static void Main()
    {
        BaseClass B = new DerivedClass();
        B.Print();//I am a Base Class Print Method
        
        DerivedClass D = new DerivedClass();
        D.Print();//I am a Derived Class Print Method
    }
}




