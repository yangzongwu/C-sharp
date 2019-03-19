using System;

namespace part1_ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/types-and-variables
            /*
            This summarizes C#’s numeric types.
            Signed Integral
                sbyte: 8 bits, range from -128 to 127
                short: 16 bits, range from -32,768 to 32,767
                int : 32 bits, range from -2,147,483,648 to 2,147,483,647
                long : 64 bits, range from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            Unsigned integral
                byte : 8 bits, range from 0 to 255
                ushort : 16 bits, range from 0 to 65,535
                uint : 32 bits, range from 0 to 4,294,967,295
                ulong : 64 bits, range from 0 to 18,446,744,073,709,551,615
            Floating point
                float : 32 bits, range from 1.5 × 10-45 to 3.4 × 1038, 7-digit precision
                double : 64 bits, range from 5.0 × 10-324 to 1.7 × 10308, 15-digit precision
            Decimal
                decimal : 128 bits, range is at least -7.9 × 10-28 to 7.9 × 1028, with at least 28-digit precision
            Character and string 
                processing in C# uses Unicode encoding. The char type represents a UTF-16 code unit, and the string 
                type represents a sequence of UTF-16 code units. 
             */
            int i = 0;
            Console.WriteLine(i);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

        }
    }
}
