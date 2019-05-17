# 1
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

# 2
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
