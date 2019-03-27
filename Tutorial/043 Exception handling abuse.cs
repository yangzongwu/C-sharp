using System;
using System.IO;
using System.Runtime.Serialization;

public class CustomExceptionsDemo
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("please enter Numerator");
            int Numerator = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter Denominator");
            int Denominator = Convert.ToInt32(Console.ReadLine());

            int result = Numerator / Denominator;

            Console.WriteLine("result={0}", result);
        }
        catch(FormatException)
        {
            Console.WriteLine("please enter a number");
        }
        catch (OverflowException)
        {
            Console.WriteLine("only number between {0} and {1} allowed", int.MinValue, int.MaxValue);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Denominator cannot be zero");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

