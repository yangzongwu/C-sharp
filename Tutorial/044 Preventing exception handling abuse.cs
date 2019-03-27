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
            int Numerator;
            bool IsNumeratorConversionSuccessful= int.TryParse(Console.ReadLine(), out Numerator);
            if (IsNumeratorConversionSuccessful)
            {
                Console.WriteLine("please enter Denominator");
                int Denominator;
                bool IsDenominatorConversionSuccessful = int.TryParse(Console.ReadLine(), out Denominator);

                if(IsDenominatorConversionSuccessful && Denominator!= 0)
                {
                    int result = Numerator / Denominator;
                    Console.WriteLine("result={0}", result);
                }
                else
                {
                    if (Denominator == 0)
                    {
                        Console.WriteLine("could not be 0");
                    }
                    else
                    {
                        Console.WriteLine("Numerator should be between {0} and {1} allowed", int.MinValue, int.MaxValue);
                    }
                }
                
            }
            else
            {
                Console.WriteLine("Numerator should be between {0} and {1} allowed", int.MinValue, int.MaxValue);
            }
           
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

