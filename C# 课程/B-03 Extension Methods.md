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
