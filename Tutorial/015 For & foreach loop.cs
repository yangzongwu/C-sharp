using System;

namespace part1_ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = new int[3];
            Numbers[0] = 101;
            Numbers[1] = 102;
            Numbers[2] = 103;

            int i = 0;
            while (i < Numbers.Length)
            {
                Console.WriteLine(Numbers[i]);
                i++;
            }

            for(int k = 0; k < Numbers.Length; k++)
            {
                Console.WriteLine(Numbers[k]);
            }

            foreach(int j in Numbers)
            {
                Console.WriteLine(j);
            }
        }
    }
}
