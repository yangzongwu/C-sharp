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
