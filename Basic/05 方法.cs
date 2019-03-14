/*本节内容
方法的由来
方法的定义与调用
构造器
方法的重载
如何对方法进行debug
方法的调用与栈*/

/*
方法的由来：
方法（method）的前身是C/C++语言的函数（function）
永远都是类（或结构体）的成员
是类（或结构体）的基本成员之一(字段与方法)
为什么需要方法和函数：隐藏赋值的逻辑，复用，把大的方法分解为小的算法*/



方法的声明与调用
声明方法的语法详解
方法的命名规范
静态方法和实例方法（静态方法属于类，不属于实例，实例化不能调用静态方法）
调用方法

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            Console.WriteLine(c.GetCircleArea(10));
        }
    }
    class Calculator
    {
        public double GetCircleArea(double r)
        {
            return Math.PI * r * r;
        }
        public double GetCylinderVolume(double r, double h)
        {
            //return 3.14 * r * r * h;
            return GetCircleArea(r) * h;
        }
        public double GetConeVolume(double r, double h)
        {
            return GetCylinderVolume(r,h)/ 3;
        }

    }
}

构造器
构造器是类型的成员之一

默认构造器
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            Console.WriteLine(stu.ID);
            Console.WriteLine(stu.Name);
        }
    }
    class Student
    {
        public int ID;
        public string Name;
    }
}

带参数构造器
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            Console.WriteLine(stu.ID);
            Console.WriteLine(stu.Name);
        }
    }
    class Student
    {
        public int ID;
        public string Name;
        public Student()
        {
            this.ID = 1;
            this.Name = "No Name";
        }
    }
}




namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student(2,"yzw");
            Console.WriteLine(stu.ID);//2
            Console.WriteLine(stu.Name);//yzw
            Student stu2 = new Student();
            Console.WriteLine(stu2.ID);//1
            Console.WriteLine(stu2.Name);//No Name
        }
    }
    class Student
    {
        public Student(int initId, string initName)
        {
            this.ID = initId;
            this.Name = initName;
        }
        public Student()
        {
            this.ID = 1;
            this.Name = "No Name";
        }
        public int ID;
        public string Name;
    }
}


方法的重载
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
          
        }
    }
    class Calculator 
    {
       public int Add(int a, int b)
        {
            return a + b;
        }
        public int Add(int a, int b, int c)
        {
            return a + b+c;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }
    }
}


debug


方法调用时栈内存的分配
对stack frame的分析
