using System;

namespace part1_ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your target?");
            int Usertarget = int.Parse(Console.ReadLine());
            int start = 0;
            while (start <= Usertarget)
            {
                Console.WriteLine(start);
                start += 2;
            }
        }
    }
}
