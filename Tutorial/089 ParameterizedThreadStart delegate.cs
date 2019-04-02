//use ParameterizedThreadStart delegate if you have some data to pass to the Thread function, otherwise just use
//ThreadStart delegate;

using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input a number");
            object target=Console.ReadLine();
            Number number = new Number();
            //ParameterizedThreadStart parameterizedThreadStart = new ParameterizedThreadStart(number.PrintNumebrs);
            //Thread T1 = new Thread(parameterizedThreadStart);
            Thread T1 = new Thread(number.PrintNumebrs);
            //it's working because the complier implicitly coverts
            //new Thread(number.PrintNumebrs)
            //to
            //new Thread(new ParameterizedThreadStart(number.PrintNumebrs) )
            T1.Start(target);//obj,
            
        }
    }
    class Number
    {
        public void PrintNumebrs(object target)
        {
            int number = 0;
            if (int.TryParse(target.ToString(), out number)){
                for (int i = 0; i <= number; i++)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
