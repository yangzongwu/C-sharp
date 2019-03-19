using System;

namespace part1_ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number");
            int userNumber=int.Parse(Console.ReadLine());
            if (userNumber == 1)
            {
                Console.WriteLine("your number is one");
            }
            else if (userNumber == 2)
            {
                Console.WriteLine("your number is two");
            }
            else if (userNumber == 3 || userNumber==4)
            {
                Console.WriteLine("your number is three or four");
            }
            else
            {
                Console.WriteLine("your number is other");
            }

        }
    }
}
