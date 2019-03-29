/*
there area 4 ways that can be used to make method parameters optional
1.Use parameter arrays
2.Method overloading
3.Specify parameter defaults
4.User OptionalAttribute that is present in System.Runtime.InteropServices namespace
*please note that, a parameter array must be the last parameter in a formal parameter list

Public static void AddNumbers(int FN,int SN,params object[] restOfNumbers){
}
*/

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            AddNumbers(10, 20);
            AddNumbers(10, 20,30,40,50);
            AddNumbers(10, 20, new object[] { 30, 40, 50 });
        }

        public static void AddNumbers(int FN, int SN, params object[] restOfNumbers)
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

