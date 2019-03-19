using System;

namespace part1_ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name");
            string firstname = Console.ReadLine();
            Console.WriteLine("Please enter your last name");
            string lastname = Console.ReadLine();

            Console.WriteLine("Hello {0} {1}" , firstname, lastname);

            Console.WriteLine("Hello " + lastname);
        }
    }
}
