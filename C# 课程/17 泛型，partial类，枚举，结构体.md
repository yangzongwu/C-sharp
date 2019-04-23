# 泛型  
* 为什么需要泛型：避免成员膨胀或者类型膨胀  
* 正交性：泛型类型（类/接口/委托/...）、泛型成员（属性/方法/字段/...）  
* 类型方法的参数判断  
* 泛型与委托、lambda表达式  

### 泛型 
```csharp
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


### 链接数据库  
```csharp
namespace HelloOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new BookstoreEntities();
            var books = dbContext.Books;
            foreach(var book in books)
            {
                Console.WriteLine(book);
            }
        }
    }
}
```
### partial类  
每次增加一列，book.cs会系统重置，但是Book2.cs由于不再该文件下，故不受影响，可以继续使用  
不同的partial类可以用不同的语言  
Book.cs
```csharp
namespace HelloOOP
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book
    {
        public int ID { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
```
Book2.cs
```csharp
namespace HelloOOP
{
    public partial class Book
    {
        public string Report()
        {
            return $"#{this.ID} Name:{this.Name} Price:{this.Price}";
        }
    }
}
```
program.cs
```csharp
namespace HelloOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new BookstoreEntities();
            var books = dbContext.Books;
            foreach(var book in books)
            {
                Console.WriteLine(book.Report());
            }
        }
    }
}
```

# 枚举  
* 认为限定取值范围的整数  
* 整数值的对应  
* 比特位式用法  
```csharp
namespace HelloOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();
            //person.Level = "boss";//不用enum，程序可能造成bug，

            Person person = new Person();
            person.Level = Level.Employee;//系统自动生成
            Person boss = new Person();
            boss.Level = Level.Boss;

            Console.WriteLine(boss.Level > person.Level);//可以比较的
            Console.WriteLine((int)Level.Employee);//0
            Console.WriteLine((int)Level.Manager);//1
            Console.WriteLine((int)Level.Boss);//400
            Console.WriteLine((int)Level.BigBoss);//401

            //枚举类比特用法
            Person person1 = new Person();
            person1.skill = Skill.Cook;//要选择多个呢？
            person1.skill = Skill.Drive | Skill.Cook | Skill.Program | Skill.Teach;
            Console.WriteLine((person1.skill & Skill.Cook) == Skill.Cook);
        }
    }

    enum Level{
        Employee,
        Manager,
        Boss=400,//可以赋值
        BigBoss,
    }

    enum Skill
    {
        Drive=1,
        Cook=2,
        Program=4,
        Teach=8,
    }
    class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Level Level { get; set; }
        public Skill skill { get; set; }

    }
}
```

# 结构体（struct）    
* 值类型，可装/拆箱  
* 可实现接口，不能派生自类/结构体  
* 不能有显示无参构造器  
```csharp
namespace HelloOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student() { ID = 101, Name = "adf" };
            object obj = stu;//装箱
            Student stu0 = (Student)obj;//拆箱
            Console.WriteLine(stu0.Name);

            //是值类型，不是引用对象
            Student stu3= new Student() { ID = 101, Name = "adf" };
            Student stu2 = stu3;
            stu2.Name = "aaa";
            stu2.ID = 1;
            stu2.Speak();
            Console.WriteLine("{0},{1}", stu3.ID, stu2.ID);//101,1

            //调用构造器
            Student stu5 = new Student( 101,"adf");
            stu5.Speak();
        }
    }

    struct Student:ISpeak{ //可以实现接口,但是不能由class派生出来
        public int ID { get; set; }
        public string Name { get; set; }

        public void Speak()
        {
            throw new NotImplementedException();
        }

        public Student() { }//结构体不能有显示的无参构造器

        public Student(int id,string name) {//结构体可以有显示的有参构造器
            this.ID = id;
            this.Name = name;
        }
    }

    interface ISpeak
    {
        void Speak();
    }
}
```
