/*
eg:
please enter the target number :
5
Sum of number is 15

Main thread retrieves the target number from the user
Main thread creates a child thread and pass the target number to child thread
The child thread computes the sum of numbers and then return the sum to the Main thread using callback function
The callback method prints the sum of numbers
*/

using System;
using System.Threading;

namespace ConsoleApp1
{
    public delegate void SumOfNumbersCallBack(int SumOfNumbers);

    class Program
    {
        public static void PrintSum(int sum)
        {
            Console.WriteLine("Sum of numbers = " + sum);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("input a number");
            int target=Convert.ToInt32(Console.ReadLine());
            SumOfNumbersCallBack callback = new SumOfNumbersCallBack(PrintSum);

            Number number = new Number(target, callback);
            Thread T1 = new Thread(new ThreadStart(number.PrintSumOfNumebrs));
            T1.Start();
        }
    }
    class Number
    {
        private int _target;
        private SumOfNumbersCallBack _callBackMethod;

        public Number(int target, SumOfNumbersCallBack callBackMethod)
        {
            this._target = target;
            this._callBackMethod = callBackMethod;
        }
        public void PrintSumOfNumebrs()
        {
            int sum = 0;
            for (int i = 0; i <= _target; i++)
                {
                sum = sum + i;
                }

            if (_callBackMethod != null)
            {
                _callBackMethod(sum);
            }
        }
    }
}
