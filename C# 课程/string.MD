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

# 文件读写
### write   
```csharp
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //path, Directory,File
            string rootPath = Path.Join("C:", "Temp");
            Console.WriteLine(rootPath);
            string dirPath = Path.Join(rootPath, "Happy");
            Directory.CreateDirectory(dirPath);//创建Happy文件夹
            string[] names = { "Time", "Mike", "Seay" };
            string filePath = Path.Join(dirPath, "names.txt");
            File.WriteAllLines(filePath, names);//写文件

            string[] allNames = File.ReadAllLines(filePath);
            foreach(var name in allNames)
            {
                Console.WriteLine(name);
            }
            //全读全写，依赖于内存缓存，不建议这么处理，只能处理小的文件
            //streaming 流式读写
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
            string filePath = Path.Combine("C:", "Temp", "Happy", "IO.txt");
            Console.WriteLine(filePath);//C:\Temp\Happy\IO.txt

            FileStream inputStream = null;
            if (File.Exists(filePath))
            {
                inputStream = File.OpenWrite(filePath);
            }
            else
            {
                inputStream = File.Create(filePath);
            }

            var streamWriter = new StreamWriter(inputStream);
            for(int i = 0; i < 9; i++)
            {
                streamWriter.WriteLine(i.ToString());
            }
            streamWriter.Flush();
            streamWriter.Close();
            inputStream.Close();

        }
       
    }
}
```

### read  
```csharp
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = Path.Combine("C:", "Temp", "Happy", "IO.txt");
            if (!File.Exists(filePath))
            {
                Console.WriteLine("error");
                return;
            }
            var outputStream = File.OpenRead(filePath);
            var streamReader = new StreamReader(outputStream);
            string line = null;
            while (!String.IsNullOrEmpty(line = streamReader.ReadLine()))
            {
                Console.WriteLine($"I GOT {line}");
            }
            streamReader.Close();
            outputStream.Close();
        }


    }
}
```

把前两列相加放到第三列
```csharp
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = Path.Combine("C:", "Temp", "Happy", "Book1.cvs");
            string filePathTemp = Path.Combine("C:", "Temp", "Happy", "Book1Temp.cvs");

            var readStream = File.OpenRead(filePath);
            var reader = new StreamReader(readStream);

            var writeStream = File.Create(filePathTemp);
            var writer = new StreamWriter(writeStream);

            string line = null;

            while (!String.IsNullOrEmpty(line = reader.ReadLine()))
            {
                var parts =line.Split(',');
                int sum = int.Parse(parts[0]) + int.Parse(parts[1]);
                var result = $"{line},{sum}";
                writer.WriteLine(result);
            }
            writer.Flush();
            writer.Close();
            writeStream.Close();
            reader.Close();
            readStream.Close();
            File.Delete(filePath);
            File.Move(filePathTemp, filePath);//改名
        }


    }
}
```
