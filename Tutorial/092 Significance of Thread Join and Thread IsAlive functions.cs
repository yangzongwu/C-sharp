/*
Join block the current thread and make it wait until the thread on which Join mehtod is invoked completes.

Join is particularly useful when we need to wait and collect result from a thread execution or if we need to 
do some clean-up after the thread has completed

IsAlivle returns boolean. True if the thread is still executing otherwise false

*/

using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Started");
            Thread T1 = new Thread(Program.Thread1Function);
            T1.Start();
            Thread T2 = new Thread(Program.Thread2Function);
            T2.Start();
            Console.WriteLine("Main Complete");

            //result, maybe different
            //Main Started
            //Main Complete
            //Thread1Function start
            //Thread2Function start
        }

        public static void Thread1Function()
        {
            Console.WriteLine("Thread1Function start");
        }
        public static void Thread2Function()
        {
            Console.WriteLine("Thread2Function start");
        }
    }

}
//===========================================================================================
using System;
using System.Threading;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Started");
            Thread T1 = new Thread(Program.Thread1Function);
            T1.Start();
            Thread T2 = new Thread(Program.Thread2Function);
            T2.Start();

            if (T1.Join(1000))
            {
                Console.WriteLine("Thread1Function Complete");
            }
            else
            {
                Console.WriteLine("Thread1Function has not Complete in 1 second");
            }

            T2.Join();
            Console.WriteLine("Thread2Function Complete");

            for(int i = 1; i <= 10; i++)
            {
                if (T1.IsAlive)
                {
                    Console.WriteLine("Thread1Function is still doing it's work ");
                    Thread.Sleep(500);
                }
                else
                {
                    Console.WriteLine("Thread1Function Complete");
                    break;
                }
            }
            

            Console.WriteLine("Main Complete");
        }

        public static void Thread1Function()
        {
            Console.WriteLine("Thread1Function start");
            Thread.Sleep(5000);
            Console.WriteLine("Thread1Function is about to return");
        }
        public static void Thread2Function()
        {
            Console.WriteLine("Thread2Function start");
        }
    }

}

