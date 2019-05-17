Fluent API is a coding style which has a little conflict with the common coding style.  
This coding style is called Fluent API. Usually, you will see 
Fluent API style in two portions of the code - LINQ and programmatic configuration.

### Common  Style
```csharp
namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var stu = new Student();
            stu.Greet("Tim");
            stu.Greet("Tom");
            stu.Greet("Tee");
        }
        public class Student
        {
            public void Greet(string name)
            {
                Console.WriteLine($"hello,{name}!");
            }
        }
    }
}
```

### Fluent API Style
```csharp
namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var stu = new Student();
            stu.Greet("Tim").Greet("Tom").Greet("Tee");
        }
        public class Student
        {
            public Student Greet(string name)
            {
                Console.WriteLine($"hello,{name}!");
                return this;
            }
        }
    }
}
```
