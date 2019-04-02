/*
what happens if shared resources are not protected from concurrent access in miltithreaded program
how to protect shared resources from concurrent access
*/

using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static int Total = 0;
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(Program.AddOneMillion);
            Thread thread2 = new Thread(Program.AddOneMillion);
            Thread thread3 = new Thread(Program.AddOneMillion);

            thread1.Start(); thread2.Start(); thread3.Start();
            thread1.Join(); thread2.Join(); thread3.Join();

            Console.WriteLine(Total);//2001958??

        }
        public static void AddOneMillion()
        {
            for(int i = 1; i <= 1000000; i++)
            {
                Total++;
            }
        }
    }

}
//================================how to solve=====================================================
        public static void AddOneMillion()
        {
            for(int i = 1; i <= 1000000; i++)
            {
                Interlocked.Increment(ref Total);
            }
        }
 //or  Interlocked is better
        static object _lock = new object();
        public static void AddOneMillion()
        {
            for(int i = 1; i <= 1000000; i++)
            {
                lock (_lock)
                {
                    Total++;
                }
            }
        }
 //========================================================================================
 using System;
using System.Threading;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static int Total = 0;
        static void Main(string[] args)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            Thread thread1 = new Thread(Program.AddOneMillion);
            Thread thread2 = new Thread(Program.AddOneMillion);
            Thread thread3 = new Thread(Program.AddOneMillion);

            thread1.Start(); thread2.Start(); thread3.Start();
            thread1.Join(); thread2.Join(); thread3.Join();

            Console.WriteLine(Total);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedTicks);//435154
        }

        static object _lock = new object();
        public static void AddOneMillion()
        {
            for(int i = 1; i <= 1000000; i++)
            {
                lock (_lock)
                {
                    Total++;
                }
            }
        }
    }

}
//=========================================================================================================
using System;
using System.Threading;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static int Total = 0;
        static void Main(string[] args)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            Thread thread1 = new Thread(Program.AddOneMillion);
            Thread thread2 = new Thread(Program.AddOneMillion);
            Thread thread3 = new Thread(Program.AddOneMillion);

            thread1.Start(); thread2.Start(); thread3.Start();
            thread1.Join(); thread2.Join(); thread3.Join();

            Console.WriteLine(Total);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedTicks);//163898
        }

        public static void AddOneMillion()
        {
            for(int i = 1; i <= 1000000; i++)
            {
                Interlocked.Increment(ref Total);
            }
        }
    }

}
