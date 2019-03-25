
using System;

interface IA
{
    void AMethod();
}
class A : IA
{
    public void AMethod()
    {
        Console.WriteLine("A");
    }
}
interface IB
{
    void BMethod();
}
class B: IB
{
    public void BMethod()
    {
        Console.WriteLine("B");
    }
}
//class AB : A, B Class can not from multiple base class
//{
//}
class AB : IA, IB
{
    A a = new A();
    B b = new B();

    public void AMethod()
    {
        a.AMethod();
    }
    public void BMethod()
    {
        b.BMethod();
    }
}
public class Program
{
    public static void Main()
    {
        AB ab = new AB();
        ab.AMethod();
        ab.BMethod();
    }
}
