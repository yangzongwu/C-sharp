//these two is the same 

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

        static object _lock = new object();
        public static void AddOneMillion()
        {
            for (int i = 1; i <= 1000000; i++)
            {
                lock (_lock)
                {
                    Total++;
                }
            }
        }
    }

}
/==================================================================================
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

        static object _lock = new object();
        public static void AddOneMillion()
        {
            for (int i = 1; i <= 1000000; i++)
            {
                Monitor.Enter(_lock);
                try
                {
                    Total++;
                }
                finally
                {
                    Monitor.Exit(_lock);
                }
            }
        }
    }

}
