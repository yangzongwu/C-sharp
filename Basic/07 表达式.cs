namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //声明语句
            //局部变量声明
            int x=100;//局部变量声明，初始化器
            int z;
            var y=100;//局部变量声明，必须要被初始化
            z = 100;
            int a, b, c;//一般不推荐使用
            a = 100;
            b = 100;
            c = a + b;
            //局部常量声明，必须要被初始化
            const int m = 100;

            //表达式语句
            Console.WriteLine("hello word");
            new Form();
            int n;
            n = 100;
            int q=100;
            q++;
            q--;
            --q;
            ++q;

        }
    }
}

块语句
block用于在只允许使用单个语句的上下文中编写多条语句。
 block:{opt}
 namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            {
            hello: Console.WriteLine("hello Word");
            goto hello;
            }//块句，不需要；，只能在方法体里面，当成完整的句子
        }
    }
}

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100;
            {
                Console.WriteLine(x);
                int y = 200;
                Console.WriteLine(y);
            }
            Console.WriteLine(y);//error
        }
    }
}


选择语句if  switch
