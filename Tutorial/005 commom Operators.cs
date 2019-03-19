using System;

namespace part1_ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assignment operator   =
            int i = 10;
            bool b = true;
            //Arithmetic operators  +,-,*,/,%
            int Numerator = 10;
            int Denominator = 2;
            int Result = Numerator / Denominator;
            //Comparison operators  ==,!=,>,<,>=,<=
            int number = 10;
            if (number == 10) { }
            //Conditional operators &&,||
            int x = 10;
            int y = 20;
            if (x == 10 && y==20){ }
            if (x == 15 || y == 20) { }
            //Ternary operator  ?
            int Number = 10;
            bool IsNumber10 = Number == 10 ? true : false;
            //bool IsNumber10;
            //if (Number == 10)
            //{
            //    IsNumber10 = true;
            //}
            //else
            //{
            //    IsNumber10 = false;
            //}
            Console.WriteLine("Number==10 is {0}", IsNumber10); 
            //Null Coalescing operator ??

        }
    }
}
