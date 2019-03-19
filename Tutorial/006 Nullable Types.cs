//https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/nullable-types/using-nullable-types

using System;
namespace part1_ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Null Coalescing operator ??
            //value types vs reference types
            //
            string s = null;
            int i = null;//this will report wrong info.

            //注意==============================
            bool? AreYouMajor = null;
            if(AreYouMajor == true)
            {
                Console.WriteLine("user is Major");
            }
            else if (!AreYouMajor.Value)
            //if(AreYouMajor == false)
            {
                Console.WriteLine("user is not Major");
            }
            else
            {
                Console.WriteLine("use is did not answer the question")
            }
        }
    }
}

//如下两段代码执行是一样的
using System;
namespace part1_ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int? TicketsOnSale = null;
            int AvaialableTickets= TicketsOnSale ?? 0;
            Console.WriteLine("AvaialableTickets {0}", AvaialableTickets);
        }
    }
}


using System;

namespace part1_ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int? TicketsOnSale = null;
            int AvaialableTickets;
            if (TicketsOnSale == null)
            {
                AvaialableTickets = 0;
            }
            else
            {
                //there two is the same to deal with some db is null
                //AvaialableTickets = TicketsOnSale.Value;
                AvaialableTickets = (int)TicketsOnSale;
            }
            Console.WriteLine("AvaialableTickets {0}", AvaialableTickets);
        }
    }
}
