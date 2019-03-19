using System;

namespace part1_ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] EvenNumbers = new int[3];
            EvenNumbers[0] = 0;
            EvenNumbers[1] = 2;
            EvenNumbers[2] = 4;
            Console.WriteLine(EvenNumbers[1]);//2
            //EvenNumbers[2] = "hello"; error
            EvenNumbers[3] = 6;//Unhandled Exception

            //Arrays are strongly typed
            //Arrays cannot grow in size once initialized
            //Have to rely on integral indices to store or retrive
            //items from array
        }
    }
}
