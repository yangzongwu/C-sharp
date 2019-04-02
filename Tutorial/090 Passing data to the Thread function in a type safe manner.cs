To pass data to the Thread function in a type safe manner,encapsulate the thread function and the data it
needs in a helper class and use the ThreadStart delegate to execute the thread function.

  using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input a number");
            int target=Convert.ToInt32(Console.ReadLine());
            Number number = new Number(target);
            Thread T1 = new Thread(new ThreadStart(number.PrintNumebrs));
            T1.Start();
        }
    }
    class Number
    {
        private int _target;
        public Number(int target)
        {
            this._target = target;
        }
        public void PrintNumebrs()
        {
            for (int i = 0; i <= _target; i++)
                {
                    Console.WriteLine(i);
                }
        }
    }
}
