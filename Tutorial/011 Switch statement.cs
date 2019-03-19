using System;

namespace part1_ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number");
            int userNumber=int.Parse(Console.ReadLine());
            switch (userNumber)
            {
                case 10:
                    Console.WriteLine("10");
                    break;
                case 20:
                    Console.WriteLine("20");
                    break;
                case 30:
                    Console.WriteLine("30");
                    break;
                default:
                    Console.WriteLine("not 10,20,30");
                    break;                
            }
        }
    }
}



using System;

namespace part1_ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number");
            int userNumber=int.Parse(Console.ReadLine());
            switch (userNumber)
            {
                case 10:
                case 20:
                case 30:
                    Console.WriteLine("{0}",userNumber);
                    break;
                default:
                    Console.WriteLine("not 10,20,30");
                    break;                
            }
        }
    }
}
