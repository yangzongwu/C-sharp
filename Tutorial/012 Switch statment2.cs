using System;

namespace part1_ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int TotalCoffeCost = 0;
            start:
            Console.WriteLine("1-Small,2-Medium,3-Large");
            int userChoise=int.Parse(Console.ReadLine());
            switch (userChoise)
            {
                case 1:
                    TotalCoffeCost += 1;
                    break;
                case 2:
                    TotalCoffeCost += 2;
                    break;
                case 3:
                    TotalCoffeCost += 3;
                    break;
                default:
                    Console.WriteLine("invalid");
                    goto start;                
            }

            Decide:
            Console.WriteLine("Do you want to buy another coffee=Yes or No?");
            string userDecision = Console.ReadLine();
            switch (userDecision.ToUpper())
            {
                case "YES":
                    goto start;
                case "NO":
                    break;
                default:
                    Console.WriteLine("Your Choise is Invalid,Please try again");
                    goto Decide;
            }
            Console.Write("Thnak you for shopping with us");
            Console.WriteLine("bill is {0}", TotalCoffeCost);
        }
    }
}
