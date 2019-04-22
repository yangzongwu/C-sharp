The exception propagates up, and should be handled at a higher level. If the exception 
is not handled at the higher level, the application crashes. The "finally" block execution 
stops at the point where the exception is thrown.  

In the example below, notice that the "finally" block in "Hello()" method throws an exception. 
Hello() method is being called in the Main() method and we don't have any exception handling 
mechanism in place in the Main() method. So, the application crashes with the exception.  
```csharp
public class Program
{
    public static void Main()
    {
        Hello();
    }

    public static void Hello()
    {
        try
        {
            // Some code
        }
        catch
        {
            // Some code
        }
        finally
        {
            Console.WriteLine("This line will be executed");
            int result = Convert.ToInt32("TEN");
            Console.WriteLine("This line will NOT be executed");
        }
    }
}
```
On the other hand, if you include exception handling mechanism(try/catch) in the Main() method, then you will have the opportunity to handle the exception.
```csharp
public static void Main()
{
    try
    {
        Hello();
    }
    catch (Exception ex)
    {
        // Process and log the exception
        Console.WriteLine(ex.Message);
    }
}
```

Irrespective of whether there is an exception or not "finally" block is guaranteed to execute.   
* If the "finally" block is being executed after an exception has occurred in the try block,     
* and if that exception is not handled  
* and if the finally block throws an exception  
Then the original exception that occurred in the try block is lost.  

Here is an example:  
```csharp
public class Program
{
    public static void Main()
    {
        try
        {
            Hello();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public static void Hello()
    {
        try
        {
            // This exception will be lost
            throw new Exception("Exception in TRY block");
        }
        finally
        {
            throw new Exception("Exception in FINALLY block");
        }
    }
}
```
