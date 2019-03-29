using System;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            AddNumbers(10, 20);
        }

        public static void AddNumbers(int FN, int SN, [Optional]int[] restOfNumbers)
        {
            int result = FN + SN;
            if (restOfNumbers != null)
            {
                foreach (int i in restOfNumbers)
                {
                    result += i;
                }
            }
            Console.WriteLine("Sum=" + result.ToString());
        }
    }

    
}
