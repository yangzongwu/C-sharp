//the InnerException property returns the Exception instance that caused the current exception

//To retain the original exception pass it as a parameter to the constructor,of the current exception

//Always check if inner exception is not null before accessing any property of the inner exception object,
//else, you may get Null Reference Exception

//To get the type of InnerException use GetType() method

using System;
using System.IO;

class Program
{
    public static void Main()
    {
        try
        {
            try
            {
                Console.WriteLine("Enter First Number");
                int FN = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Second Number");
                int SN = Convert.ToInt32(Console.ReadLine());

                int Result = FN / SN;

                Console.WriteLine("Result={0}", Result);
            }
            catch (Exception ex)
            {
                string filePath = @"C:\Users\yzw\Desktop\21.txt";
                if (File.Exists(filePath))
                {
                    StreamWriter sw = new StreamWriter(filePath);
                    sw.Write(ex.GetType().Name);
                    sw.WriteLine();
                    sw.Write(ex.Message);
                    sw.Close();
                    Console.WriteLine("There is a problem, Please try later");
                }
                else
                {
                    throw new FileNotFoundException(filePath + "is not present", ex);
                }
            }
        }
        catch(Exception exception)
        {
            Console.WriteLine("Current exception = {0}", exception.GetType().Name);
            if (exception.InnerException != null)
            {
                Console.WriteLine("Inner exception = {0}", exception.InnerException.GetType().Name);
            }
        }
        
    }
}
