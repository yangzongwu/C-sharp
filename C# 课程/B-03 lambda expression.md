Lambda Expression is A lambda expression is an anonymous function that you can use to create delegates or expression tree types.
Here, to use lambda expression with LINQ, we just need to understand two points in this definition:
* What is anonymous function.
* How to create delegate instances using lambda expressions.

# The Action Delegates and Lambda Expression
the evaluation result of a lambda expression is a delegate instance

```csharp
static void SayHello() {
    Console.WriteLine("Hello, World!");
}
```

```csharp
class Program {
    static void Main(string[] args) {
        Action action = SayHello;
        action();
    }

    static void SayHello() {
        Console.WriteLine("Hello, World!");
    }
}
```

```csharp
class Program {
    static void Main(string[] args) {
        Action action = () => { Console.WriteLine("Hello, World"); };
        //Action action = () => Console.WriteLine("Hello, World");
        action();
    }
}
```

# The Func Delegates and Lambda Expression
```csharp
public delegate TResult Func<in T, out TResult>(T arg);
```

```csharp
class Program {
    static void Main(string[] args) {
        Func<string, int> func = (s) => { return s.Length; };
        //Func<string, int> func = s => s.Length;
        int x = func("Hello");
        Console.WriteLine(x);
    }
}
```
* What we did to simplify the lambda expression includes:
  * Remove the unnecessary () around the parameter.
  * Remove the {} around the single return statement.
  * Without the {}, there can only be a single expression, and the evaluation result of this expression is just the return value of the lambda expression.


* By showing this code, I want to emphasize two points to you:
  * Sometimes the parameter type and the return value type of a lambda expression can be the same one. In this code, both the parameter type and the return value type are string. It's pointed out by Func<string, string>.
  * Sometimes the body of the lambda expressions can be as easy as just returning the parameter directly (s => s) or returning a simple property of the parameter (s => s.Length).
```csharp
class Program {
    static void Main(string[] args) {
        Func<string, string> func1 = s => s.Substring(0, 3);
        Func<string, string> func2 = s => s;
        var r1 = func1("Timothy");
        var r2 = func2("Timothy");
        Console.WriteLine($"'{r1}' is the first three characters of '{r2}'.");
        //'Tim' is the first three characters of 'Timothy'.
    }
}
```

# Multi-Parameters Delegates
 a Func delegate, in its type parameter list, the last type parameter is always the type of the return value.
 the length of the type parameter list of those Func delegates used by LINQ is just two or three. That means 
 the lambda expressions used by LINQ will just have one or two parameters. 
```csharp
namespace FuncExample {
    class Program {
        static void Main(string[] args) {
            Func<string, int, string> strHead = (str, len) => str.Substring(0, len);
            var result = strHead("Timothy", 3);
            System.Console.WriteLine(result);
        }
    }
}
```

Action- delegates can only reference those methods don't have return value (void methods). So, the generic 
type parameters (T, T1, T2, etc) are all for the parameters of the methods. 
```csharp
namespace ActionExample {
    class Program {
        static void Main(string[] args) {
            Action<double, double, double> sum3 = (x, y, z) => Console.WriteLine(x + y + z);
            sum3(1.1, 2.2, 3.3);
        }
    }
}
```

# Function delegate example

