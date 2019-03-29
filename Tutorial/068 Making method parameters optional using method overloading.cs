using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            AddNumbers(10, 20);
            AddNumbers(10, 20,null);
            AddNumbers(10, 20, new int[] { 30, 40, 50 });
        }

        public static void AddNumbers(int FN, int SN)
        {
            AddNumbers(FN, SN, null);
        }

        public static void AddNumbers(int FN, int SN, int[] restOfNumbers)
        {
            int result = FN + SN;
            if (restOfNumbers != null)
            {
                foreach (int i in restOfNumbers)
                {
                    result += i;
                }
            }
            Console.WriteLine("Sum=" + result);
        }
    }

    
}
