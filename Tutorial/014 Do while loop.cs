using System;

namespace part1_ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string UserChoice = "";
            do
            {
                Console.WriteLine("Please enter your target?");
                int Usertarget = int.Parse(Console.ReadLine());
                int start = 0;
                while (start <= Usertarget)
                {
                    Console.WriteLine(start);
                    start += 2;
                }

                do
                {
                    Console.WriteLine("Do you want to continue");
                    UserChoice = Console.ReadLine();
                    if (UserChoice != "Yes" && UserChoice != "No")
                    {
                        Console.WriteLine("Invalid choise,please say Yes or No");
                    }
                }
                while (UserChoice != "Yes" && UserChoice != "No");
            } while (UserChoice == "Yes");

        }
    }
}
