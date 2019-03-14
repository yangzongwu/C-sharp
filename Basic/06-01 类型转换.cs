隐式类型转换

不丢失精度转换
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.MaxValue;
            long y = x;
            Console.WriteLine(y);
        }
    }
}

子类向父类转换
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher t = new Teacher();
            Human h = t;
            Animal a = h;
            h.Think();
            t.Teach();
            h.Teach();//wrong
            a.Eat();//Think(),Teach() 都没有
        }
    }
    class Animal 
    {
       public void Eat()
        {
            Console.WriteLine("Eating");
        }
    }
    class Human : Animal
    {
        public void Think()
        {
            Console.WriteLine("Think");
        }
    }
    class Teacher : Human
    {
        public void Teach()
        {
            Console.WriteLine("Teach");
        }
    }
}



显示类型转换

有可能精度丢失
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ushort.MaxValue);
            uint x = 65536;
            ushort y = (ushort)x;
            Console.WriteLine(y);
        }
    }
}

使用convert类
Parse/TryParse
