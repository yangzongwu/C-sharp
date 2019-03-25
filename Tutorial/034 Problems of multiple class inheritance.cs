
using System;

class A
{
    public virtual void Print()
    {
        Console.WriteLine("A Implementation");
    }
}
class B : A
{
    public override void Print()
    {
        Console.WriteLine("B Implementation");
    }
}
class C : A
{
    public override void Print()
    {
        Console.WriteLine("C Implementation");
    }
}
class D : B,C//Diamond Problem, print from B?C?
{
}
public class Program
{
    public static void Main()
    {
        D d = new D();
        d.Print();
    }
}
