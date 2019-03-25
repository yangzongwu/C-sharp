//C# functions can be overloaded based on the number,type(int,float etc) 
//and kind(Value,Ref,Out) of parameters

//return type and parameter can not used to overload functions


using System;
class Program
{
    public static void Main()
    {
        Add(1,2);
    }
    public static void Add(int FN, int SN)
    {
        Console.WriteLine("Sum={0}", FN + SN);
    }
    public static void Add(int FN, int SN,int TN)
    {
        Console.WriteLine("Sum={0}", FN + SN);
    }
    public static void Add(float FN, float SN)
    {
        Console.WriteLine("Sum={0}", FN + SN);
    }
    public static void Add(int FN, float SN)
    {
        Console.WriteLine("Sum={0}", FN + SN);
    }
}


using System;

class Program
{
    public static void Main()
    {
        Add(1,2,3);
    }
    public static void Add(int FN, int SN,int TN)
    {
        Console.WriteLine("Sum={0}", FN + SN);
    }
    public static void Add(int FN, int SN, out int Sum)
    {
        Console.WriteLine("Sum={0}", FN + SN);
        Sum = FN + SN;
    }
}
