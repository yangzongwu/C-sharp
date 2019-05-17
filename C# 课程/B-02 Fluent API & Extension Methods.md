# Fluent API
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

# Extension methods
Extension methods enable you to “attach” methods to existing types without creating a new derived type, 
recompiling, or otherwise modifying the original type. Extension methods are a special kind of static methods, 
but they are called as if they are instance methods on the extended type.  

```csharp
namespace Linq
{
    public static class StringExtension
    {
        public static string Quote(this string str)
        {
            return $"\"{str}\"";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var original = "ABCDE";
            var quoted = original.Quote();
            Console.WriteLine(original);
            Console.WriteLine(quoted);
        }
    }
}
```
* As we see in the code example, the syntax of declaring an extension method is to
  * declare a static method in a static class, and
  * use the this modifier to modify the first parameter of the static method.
  * The type of the first parameter will be the target type this extension method attaches to.
  * When calling the extension method, we don't need to provide argument for the first parameter, 
  since the C# compiler will treat the caller of the extension method as the argument for the first argument.
  
* There are only two points you should pay attention to:
  * Both the extension method and the host class must be static.
  * The first parameter of extension method must be modified by this. When the method is invoked, 
  this parameter won't appear in the parameter list, since the entity who is calling this method is 
  exactly the parameter. That means, when calling an extension method, the argument list is always 
  shorter than the parameter list of the declaration by one.
  
```csharp
namespace Trimming {
    static class DoubleExtension {
        public static double Round(this double value, int digits) {
            return Math.Round(value, digits);
        }
    }

    class Program {
        static void Main(string[] args) {
            var d = 12.3456789;
            var r1 = d.Round(2);
            var r2 = d.Round(4);
            Console.WriteLine(d);
            Console.WriteLine(r1);
            Console.WriteLine(r2);
        }
    }
}
```

# Extension Methods with Interfaces
if we want to attach the same group of extension methods to multiple types? 
The answer is by using interfaces or abstract classes. 
If we attach extension methods to an interface or abstract class, 
all derived classes will have these extension methods attached too.
```csharp
namespace Linq
{
    public interface IWorker
    {
        string Name { get; set; }
        int YearsOfExperience { get; set; }
        string Scope { get; set; }
    }

    public class Writer : IWorker
    {
        public string Name { get; set; }
        public int YearsOfExperience { get; set; }
        public string Scope { get; set; }
        public void Write() { /*...*/ }
    }

    public class Teacher : IWorker
    {
        public string Name { get; set; }
        public int YearsOfExperience { get; set; }
        public string Scope { get; set; }
        public void Teach() { /*...*/ }
    }
    public static class IWorkerExtension
    {
        public static void Introduce1(this IWorker worker)
        {
            Console.WriteLine($"Hi, my name is {worker.Name}.");
        }

        public static void Introduce2(this IWorker worker)
        {
            Console.WriteLine($"My major scope is {worker.Scope}.");
        }

        public static void Introduce3(this IWorker worker)
        {
            Console.WriteLine($"I have {worker.YearsOfExperience} years experience.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var writer = new Writer
            {
                Name = "Timothy",
                Scope = ".NET Core",
                YearsOfExperience = 15
            };

            writer.Introduce1();
            writer.Introduce2();
            writer.Introduce3();
        }
    }
}
```

# Exercise 1
create an instance of the Teacher class and try calling the extension methods 
for the IWorker interface we declared in the previous example.
```csharp
namespace Linq
{
    public interface IWorker
    {
        string Name { get; set; }
        int YearsOfExperience { get; set; }
        string Scope { get; set; }
    }
    public class Teacher : IWorker
    {
        public string Name { get; set; }
        public int YearsOfExperience { get; set; }
        public string Scope { get; set; }
        public void Teach() { /*...*/ }
    }
    public static class IWorkerExtension
    {
        public static void Introduce1(this IWorker worker)
        {
            Console.WriteLine($"Hi, my name is {worker.Name}.");
        }

        public static void Introduce2(this IWorker worker)
        {
            Console.WriteLine($"My major scope is {worker.Scope}.");
        }

        public static void Introduce3(this IWorker worker)
        {
            Console.WriteLine($"I have {worker.YearsOfExperience} years experience.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var teacher = new Teacher
            {
                Name = "Timothy",
                Scope = ".NET Core",
                YearsOfExperience = 15
            };
            teacher.Introduce1();
            teacher.Introduce2();
            teacher.Introduce3();
        }
    }
}
```

# Exercise 2
Also, there's a small challenge for you: Can you upgrade the extension methods in 
the IWorkerExtension class to Fluent API style and call them in code?
```csharp
namespace Linq
{
    public interface IWorker
    {
        string Name { get; set; }
        int YearsOfExperience { get; set; }
        string Scope { get; set; }
    }

    public class Writer : IWorker
    {
        public string Name { get; set; }
        public int YearsOfExperience { get; set; }
        public string Scope { get; set; }
        public void Write() { /*...*/ }
    }

    public class Teacher : IWorker
    {
        public string Name { get; set; }
        public int YearsOfExperience { get; set; }
        public string Scope { get; set; }
        public void Teach() { /*...*/ }
    }
    public static class IWorkerExtension
    {
        public static IWorker Introduce1(this IWorker worker)
        {
            Console.WriteLine($"Hi, my name is {worker.Name}.");
            return worker;
        }

        public static IWorker Introduce2(this IWorker worker)
        {
            Console.WriteLine($"My major scope is {worker.Scope}.");
            return worker;
        }

        public static IWorker Introduce3(this IWorker worker)
        {
            Console.WriteLine($"I have {worker.YearsOfExperience} years experience.");
            return worker;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var writer = new Writer
            {
                Name = "Timothy",
                Scope = ".NET Core",
                YearsOfExperience = 15
            };

            writer.Introduce1().Introduce2().Introduce3();
        }
    }
}
```

# Exercise 3
```csharp
namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = 3.14;
            var df = string.Format("${0}", d);
            Console.WriteLine(d);
            Console.WriteLine(df);
            var dff = d.FormatWith("${0}");
            Console.WriteLine(dff);

            var s = "Timothy";
        }        
    }
    static class FormatExtension
    {
        public static string FormatWith(this double caller, string template)
        {
            if (string.IsNullOrEmpty(template) || template.Contains("{0}")){
                throw new ArgumentException("Please write a good template");
            }
            var result = string.Format(template, caller);
            return result;
        }
    }
}
```


change double to object
```csharp
namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = "Timothy";
            var sf = s.FormatWith("hello,{0}");
            Console.WriteLine(sf);
        }
        
    }
    static class FormatExtension
    {
        public static string FormatWith(this object caller, string template)
        {
            if (string.IsNullOrEmpty(template) || template.Contains("{0}")){
                throw new ArgumentException("Please write a good template");
            }
            var result = string.Format(template, caller);
            return result;
        }
    }
}
```
