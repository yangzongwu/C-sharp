# string 
```csharp
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str0 = "";
            string str = String.Empty;//建议
            Console.WriteLine(String.IsNullOrEmpty(str));//是空的
            Console.WriteLine(String.IsNullOrWhiteSpace(str));//空或者空格值
            //property
            
        }
    }
}
```


```csharp
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 1, 2, 3, 4, 5 };
            Iter(x);

            Iter(new int[] { 1, 2, 3, 4, 5 });

            Iter1(1, 2, 3, 4, 5);
        }
        public static void Iter(int[] a)
        {
            foreach(var i in a)
            {
                Console.WriteLine(i);
            }
        }
        public static void Iter1(params int[] a)
        {
            foreach (var i in a)
            {
                Console.WriteLine(i);
            }
        }
    }
}
```


```csharp
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "hello", s2 = "world", s3 = "happy";
            string result = String.Concat(s1, s1, s2, s3);
            Console.WriteLine(result);// hellohelloworldhappy
            string res = String.Join(',', s1, s2, s3);
            Console.WriteLine(res);//hello,world,happy");

            Console.WriteLine(s1.Contains("ll"));//True

            Console.WriteLine(s1.EndsWith("lo"));//True
            Console.WriteLine(s1.StartsWith("he"));//True

            string str0 = $"{1}+{2}={3}";
            //Format 注意

            string str = "ABCDEFABCD";
            Console.WriteLine(str.IndexOf('A'));//0
            Console.WriteLine(str.IndexOf('A', 1));
            
            string s = "A,B,C,C,,D";
            var rep=s.Split(',', StringSplitOptions.RemoveEmptyEntries);//去掉空格
            foreach(var str0 in rep)
            {
                Console.WriteLine(str0);
            }

            Console.WriteLine(s.Substring(1,1));//,

            string str = ".....abcd$   ";
            Console.WriteLine(str.Trim(",.$ ".ToCharArray()));//abcd

        }
       
    }
}
```
