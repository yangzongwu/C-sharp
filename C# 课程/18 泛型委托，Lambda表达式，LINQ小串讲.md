# 委托调用

### void类型
```csharp
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDele dele1 = new MyDele(M1);
            dele1.Invoke();//M1 is called
            dele1 += M1;
            dele1.Invoke();//M1 is called,M1 is called
            Student stu = new Student();
            dele1 += stu.SayHello;
            dele1.Invoke();//M1 is called,M1 is called,hello
            dele1();//Invoke可省略
        }

        static void M1()
        {
            Console.WriteLine("M1 is called");
        }
    }
    class Student
    {
        public void SayHello()
        {
            Console.WriteLine("hello");
        }
    }

    delegate void MyDele();
}
```

### 含参类型
```csharp
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDele dele1 = new MyDele(Add);
            int res = dele1(100, 200);
            Console.WriteLine(res);//300
        }

        static int Add(int x,int y)
        {
            return x + y;
        }
    }
    delegate int MyDele(int a,int b);
}
```
### 泛型委托
```csharp
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDele<int> deleAdd = new MyDele<int>(Add);
            int res = deleAdd(1, 2);

            MyDele<double> deleAdd1 = new MyDele<double>(Add);
            double res1 = deleAdd1(1.2, 2.1);

        }
        static int Add(int a,int b)
        {
            return a + b;
        }
        static double Add(double a,double b)
        {
            return a + b;
        }
    }

    delegate T MyDele<T>(T a,T b);
}
```

### 系统自带delegate
```csharp
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Action action = new Action(M1);
            action();//M1 is called
            Action<string> action1 = new Action<string>(SayHello);
            action1("hello");//hello
            Action<String, String> action2 = new Action<string, string>(SayHello);
            action2("hello","y");//hello,y

            Func<int, int, int> func1 = new Func<int, int, int>(Add);
            int res = func1(100, 200);//300

            Func<double, double, double> func2 = new Func<double, double, double>(Add);
            double res2 = func2(1.1, 2.1);//3.2
        }
        static void M1()
        {
            Console.WriteLine("M1 is called");
        }

        static void SayHello(string name)
        {
            Console.WriteLine(name);
        }
        static void SayHello(string a, string b)
        {
            Console.WriteLine("{0},{1}",a,b);
        }
        static int Add(int a,int b)
        {
            return a + b;
        }
        static double Add(double a,double b)
        {
            return a + b;
        }
    }
}
```

# Lambda表达式    
* 匿名方法    
* Inline 方法  
### 基本表达
```charp
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = Add(100, 200);//300
            Func<int, int, int> func = new Func<int, int, int>((int a, int b) => { return a + b; });
            res = func(100, 200);//300
            Func<int, int, int> func2 = new Func<int, int, int>((a, b) => { return a + b; });
            res = func2(100, 200);//300
            Func<int, int, int> func3 = (a, b) => { return a + b; };
            res = func3(100, 200);//300
            func = new Func<int, int, int>((int x, int y) => { return x * y; });
            res = func(3, 4);//12
            func = (x, y) => { return x * y; };
        }
        static int Add(int a ,int b)
        {
            return a + b;
        }
    }
}
```

```csharp
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            DoSomeCalc((a,b) => { return a * b; }, 100, 200);
        }
        static void DoSomeCalc<T>(Func<T, T, T> func, T x,T y)
        {
            T res=func(x, y);
            Console.WriteLine(res);
        }
    }
}
```
