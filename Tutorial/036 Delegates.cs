//A delegate is a type safe function pointer.That is , it holds a reference(Pointer) to a function

//The signature of the delegate must match the signature of the function,the delegate points to ,
//otherwise you get a compiler error.This is the reason why called type safe function pointers.

//A delegate is similar to a class.You can create an instance of it,and when you do so, you pass in the 
//funcion name as a parameter to the delegate consturctor, and it is to this function the delegate will point to
using System;

public delegate void HelloFunctionDelegate(string Message);

    public class Program
{
    public static void Main()
    {
        HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
        del("Hello from Delegate");//Hello from Delegate
        //A delegate is a type safe function pointer
    }
    public static void Hello(string strMessage)
    {
        Console.WriteLine(strMessage);
    }
}
