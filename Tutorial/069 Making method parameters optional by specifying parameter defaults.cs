// optional parameters must appear after all required parameters

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            AddNumbers(10, 20);
            AddNumbers(10, 20,new int[] { 1,2,3});
            AddNumbers1(10, 20);//wrong
        }
        public static void AddNumbers1(int FN, int SN, int[] restOfNumbers)
        { }
        public static void AddNumbers(int FN, int SN, int[] restOfNumbers=null)
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
//=====================================================================
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Test(1, 2);//a=1b=2c=20
            Test(1, c: 2);//a=1b=10c=2
        }
        public static void Test(int a, int b=10, int c=20)
        {
            Console.Write("a=" + a);
            Console.Write("b=" + b);
            Console.WriteLine("c=" + c);
        }
    }
}
