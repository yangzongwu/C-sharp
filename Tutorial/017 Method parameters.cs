Methed parameter types
1.value parameter
2.refetence parameter
3.out parameter
4.parameter arrays


//pass by value/reference
using System;
namespace part1_ConsoleApp1
{
    class Program
    {
        public static void Main()
        {
            int i = 0;
            SimpleMeMethod(i);
            Console.WriteLine(i);//0
            SimpleMeMethod2(ref i);
            Console.WriteLine(i);//101
        }
        public static void SimpleMeMethod(int j)
        {
            j = 101;
        }
        public static void SimpleMeMethod2(ref int j)
        {
            j = 101;
        }
    }
}

//out parameter 输出多个参数
using System;
namespace part1_ConsoleApp1
{
    class Program
    {
        public static void Main()
        {
            int Total = 0;
            int Product = 0;
            Calculate(10, 20, out Total, out Product);
            Console.WriteLine("Sum ={0} & Product={1}", Total, Product);
            
        }
        public static void Calculate(int i,int j,out int Sum,out int Product)
        {
            Sum= i + j;
            Product = i * j;
        }
        
    }
}


//parameter arrays
using System;

namespace part1_ConsoleApp1
{
    class Program
    {
        public static void Main()
        {
            int[] Numbers = new int[3];
            Numbers[0] = 101;
            Numbers[1] = 102;
            Numbers[2] = 103;
            ParamsMethod();
            Console.WriteLine("====");
            ParamsMethod(Numbers);
            Console.WriteLine("====");
            ParamsMethod(1, 2, 3, 4, 5);

        }
        //public static void ParamsMethod(int x,params int[] Numbers) ok
        //public static void ParamsMethod(params int[] Numbers,int x) not ok
        public static void ParamsMethod(params int[] Numbers)
        {
            Console.WriteLine("There are {0} elemnts",Numbers.Length);
            foreach(int i in Numbers)
            {
                Console.WriteLine(i);
            }
        }
        
    }
}
