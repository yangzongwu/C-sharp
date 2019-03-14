构成C#语言基本元素(前五类算标记 token)
  关键字 Key word 
  操作符 Operator
  标识符 Identifier
  标点符号
  文本
  注释与空白
    //单行  ctrl +e+c 增加注释  ctrl+k+u 消除注释
    /* 不能嵌套  */
  
  
类型，变量与方法
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 3;
            Console.WriteLine(x.GetType().Name);
            double y;
            y = 3.0;
            Calculator c = new Calculator();
            c.PrintSum(4,6);
            int z = c.Add(2, 3);
            Console.WriteLine(z);
            string str = c.Today();
            Console.WriteLine(str);
        }
    }
    class Calculator
    {
        //  有变量输入，有变量输出
        public int Add(int a, int b)
        {
            int result = a + b;
            return result;
        }
        //  无变量输入，有变量输出
        public string Today()
        {
            int day = DateTime.Now.Day;
            return day.ToString();
        }
        //  有变量输入，无变量输出,，需要void
        public void PrintSum(int a, int b)
        {
            int result = a + b;
            Console.WriteLine(result);
        }
    }
}



算法简介
