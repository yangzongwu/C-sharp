using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread T1 = new Thread(Number.PrintNumebrs);
            //we can rewrite the above line using ThreadStart delegate as show below
            //Thread T1 = new Thread(new ThreadStart(Number.PrintNumebrs));
            //Thread T1 = new Thread(delegate() { Number.PrintNumebrs(); });
            //Thread T1 = new Thread(()=>Number.PrintNumebrs());
            T1.Start();
        }
    }
    class Number
    {
        public static void PrintNumebrs()
        {
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
