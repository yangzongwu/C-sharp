# 泛型  
* 为什么需要泛型：避免成员膨胀或者类型膨胀  
* 正交性：泛型类型（类/接口/委托/...）、泛型成员（属性/方法/字段/...）  
* 类型方法的参数判断  
* 泛型与委托、lambda表达式  

### 泛型 
```sharp
namespace HelloOOP//类型膨胀
{
    class Program {
        static void Main(string[] args){
            Apple apple = new Apple() { Color = "Red" };
            AppleBox applebox = new AppleBox() { Cargo = apple };
            Console.WriteLine(applebox.Cargo.Color);

            Book book = new Book() { Name = "new book" };
            BookBox bookbox = new BookBox() { Cargo = book };
            Console.WriteLine(bookbox.Cargo.Name);
            //出现问题，类型膨胀，如果商品再增加？？？
        }
    }
    class Apple
    {
        public string Color { get; set; }
    }
    class Book
    {
        public string Name { get; set; }
    }
    class AppleBox
    {
        public Apple Cargo { get; set; }
    }
    class BookBox
    {
        public Book Cargo { get; set; }
    }
}
```

```csharp
namespace HelloOOP//成员膨胀
{
    class Program {
        static void Main(string[] args){
            Apple apple = new Apple() { Color = "Red" };
            Book book = new Book() { Name = "new book" };
            Box box1 = new Box() { Apple = apple };
            Box box2 = new Box() { Book = book };//每次只用一个属性，其他属性浪费
        }
    }
    class Apple
    {
        public string Color { get; set; }
    }
    class Book
    {
        public string Name { get; set; }
    }
    class Box
    {
        public Apple Apple { get; set; }
        public Book Book { get; set; }
    }
}
```
```csharp
namespace HelloOOP
{
    class Program {
        static void Main(string[] args){
            Apple apple = new Apple() { Color = "Red" };
            Book book = new Book() { Name = "new book" };
            Box<Apple> box1 = new Box<Apple>() { Cargo = apple };
            Box<Book> box2 = new Box<Book>() { Cargo = book };
            Console.WriteLine(box1.Cargo.Color);
            Console.WriteLine(box2.Cargo.Name);
        }
    }
    class Apple
    {
        public string Color { get; set; }
    }
    class Book
    {
        public string Name { get; set; }
    }
    class Box<TCargo>//标识符，范化
    {
        public TCargo Cargo { get; set; }
    }
}
```

### 泛型接口实例  
###### 泛型接口实例一     
```csharp
namespace HelloOOP
{
    class Program {
        static void Main(string[] args){
            Student<int> stu = new Student<int>();
            stu.ID = 101;
            stu.Name="yzw";
        }
    }

    interface IUnique<TId>
    {
        TId ID { get; set; }
    }
    class Student<TId> : IUnique<TId>
    {
        public TId ID { get; set; }
        public string Name { get; set; }
    }
}
```

###### 泛型接口实例二     
类可以先客化    
```csharp
namespace HelloOOP
{
    class Program {
        static void Main(string[] args){
            Student stu = new Student();
            stu.ID = 101;
            stu.Name="yzw";
        }
    }

    interface IUnique<TId>
    {
        TId ID { get; set; }
    }
    class Student : IUnique<ulong>
    {
        public ulong ID { get; set; }
        public string Name { get; set; }
    }
    
}
```


######  实例  
```csharp
namespace HelloOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<int> list = new List<int>();//可以带多个参数，IDictionary<int,string>
            for (int i = 0; i < 100; i++)
            {
                list.Add(i);
            }
        }
    }
}
```
算法也可以泛化   
```csharp
namespace HelloOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = { 1, 2, 3, 4, 5 };
            int[] a2 = { 1, 2, 3, 4, 5, 6 };
            double[] a3 = { 1.1, 2.2, 3.3, 4.4, 5.5 };
            double[] a4 = { 1.1 };
            var result = Zip(a1, a2);
        }
        static T[] Zip<T>(T[] a, T[] b)
        {
            T[] zipped = new T[a.Length + b.Length];
            int ai = 0;
            int bi = 0;
            int zi = 0;
            do
            {
                if (ai < a.Length) { zipped[zi++] = a[ai++]; }
                if (bi < b.Length) { zipped[zi++] = b[bi++]; }
            } while (ai < a.Length || bi < b.Length);
            return zipped;
        }
    }
}
```
### 泛型委托实例  
###### Action 泛型委托
```csharp
namespace HelloOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Action 泛型委托只能委托没有引用值的方法
            Action<string> a1 = Say;
            a1("dfsgfdhg");
            Action<int> a2 = Mul;
            a2(100);
        }
       static void Say(string str)
        {
            Console.WriteLine($"hello,{str}");
        }
        static void Mul(int x)
        {
            Console.WriteLine(x * 100);
        }
    }
}
```

###### Func 泛型委托
```csharp
namespace HelloOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> func1 = Add;
            var result = func1(100, 200);
            Func<double, double, double> func2 = Add;
            var result1 = func1(100, 200);
        }
       static int Add(int a,int b)
        {
            return a + b;
        }
        static double Add(double a, double b)
        {
            return a + b;
        }
    }
}
```
######  泛型委托 与 lambda
```csharp
namespace HelloOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<double, double, double> func2 = (a,  b) => { return a + b; };
            var result1 = func2(100, 200);
        }
    }
}
```
# partial类 
* 减少类的派生  
* partial 类与 Entity Framework 
* partial 类与 Windows Forms,WPF,ASP.NET.Core


# 枚举  

# 结构体  
