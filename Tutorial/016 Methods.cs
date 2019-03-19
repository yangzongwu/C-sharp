using System;

namespace part1_ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            Program p = new Program();
            p.EvenNumbers(10);
            p.Add(1, 2);//instance
            Program.EvenNumbers2(30);//static
        }

        public int Add(int Fn,int SN)
        {
            return Fn + SN;
        }
        public void EvenNumbers(int target)
        {
            int start = 0;
            while (start <= target)
            {
                Console.WriteLine(start);
                start += 2;
            }
        }
        public static void EvenNumbers2( int target)
        {
            int start = 0;
            while (start <= target)
            {
                Console.WriteLine(start);
                start += 2;
            }
        }
    }
}
