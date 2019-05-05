# 本节内容 
* 操作符概览
* 操作符本质
* 操作符的优先级
* 同级操作符的运算顺序
* 各类操作符的示例

operator 操作符
operand 操作数




C# 提供了许多运算符，这些运算符是指定要在表达式中执行哪些操作（数学、索引、函数调用等等）的符号。 可以重载许多应用于用户定义类型的运算符，
从而更改其含义。
对整数类型执行的运算（如 ==、!=、<、>、&、|）通常也可对枚举 (enum) 类型执行。
以下章节按最高优先级到最低优先级的顺序列示 C# 运算符。 各章节内运算符的优先级相同。

主要运算符
以下是具有最高优先级的运算符。
x.y：成员访问。
x?.y：null 条件成员访问。 如果左操作数计算结果为 null，则返回 null。
x?[y]：null 条件索引访问。 如果左操作数计算结果为 null，则返回 null。
f(x)：函数调用。
a[x]：聚合对象索引。
x++：后缀递增。 先返回 x 值，然后用加 1（通常加整数 1）后的 x 值更新存储位置。
x--：后缀递减。 先返回 x 值，然后用减 1（通常减整数 1）后的 x 值更新存储位置。
new：类型实例化。
typeof - 返回表示操作数的 Type 对象。
checked：对整数运算启用溢出检查。
unchecked：对整数运算禁用溢出检查。 这是默认的编译器行为。
default(T) - 生成类型 T 的默认值。
delegate：声明并返回委托实例。
sizeof：返回类型操作数的大小（以字节为单位）。
->：指针取消引用与成员访问相结合。

一元运算符
这些运算符的优先级比下一章节高，比上一章节低。
+x：返回 x 的值。
-x：数值取反。
!x：逻辑取反。
~x：按位求补。
++x：前缀递增。 先用加 1（通常加整数 1）后的 x 值更新存储位置，然后返回 x 值。
--x：前缀递减。 先用减 1（通常减整数 1）后的 x 值更新存储位置，然后返回 x 值。
(T)x：类型显式转换。
await：等待 Task。
&x：地址。
*x：取消引用。

乘法运算符
这些运算符的优先级比下一章节高，比上一章节低。
x * y：乘法。
x / y：除法。 如果操作数均为整数，则结果为整数，舍去小数（例如，-7 / 2 is -3）。
x % y：余数。 如果操作数均为整数，则返回 x 除以 y 后的余数。 如果 q = x / y 且 r = x % y，则 x = q * y + r。

相加运算符
这些运算符的优先级比下一章节高，比上一章节低。
x + y：加法。
x - y：减法。

移位运算符
这些运算符的优先级比下一章节高，比上一章节低。
x << y：左移位，右侧用 0 填充。
x >> y：右移位。 如果左操作数是 int 或 long，则左位数补符号位。 如果左操作数是 uint 或 ulong，则左位数补零。

关系和类型测试运算符
这些运算符的优先级比下一章节高，比上一章节低。
x < y：小于（如果 x 小于 y，则为 true）。
x > y：大于（如果 x 大于 y，则为 true）。
x <= y：小于或等于。
x >= y：大于或等于。
is：类型兼容性。 如果求值后的左操作数可以转换为右操作数中指定的类型（静态类型），则返回 true。
as：类型转换。 返回左操作数并转换为右操作数中指定的类型（静态类型），但 as 返回 null，其中 (T)x 会引发异常。

相等运算符
这些运算符的优先级比下一章节高，比上一章节低。
x == y：相等。 默认情况下，对于 string 以外的引用类型，此运算符返回引用相等（标识测试）。 但是，类型可以重载 ==，因此，如果你想测试标识，最好对 object 使用 ReferenceEquals 方法。
x != y：不相等。 请参阅有关 == 的注释。 如果某个类型重载 ==，则它必须重载 !=。

逻辑 AND 运算符
此运算符的优先级比下一章节高，比上一章节低。
x & y：逻辑或位 AND。 通常可以将此运算符与整数类型和 enum 类型一起使用。

辑 XOR 运算
此运算符的优先级比下一章节高，比上一章节低。
x ^ y：逻辑或位 XOR。 通常可以将此运算符与整数类型和 enum 类型一起使用。

逻辑 OR 运算符
此运算符的优先级比下一章节高，比上一章节低。
x | y：逻辑或位 OR。 通常可以将此运算符与整数类型和 enum 类型一起使用。

条件 AND 运算符
此运算符的优先级比下一章节高，比上一章节低。
x && y：逻辑 AND。 如果第一个操作数计算结果为 false，则 C# 不对第二个操作数求值。

条件 OR 运算符
此运算符的优先级比下一章节高，比上一章节低。
x || y：逻辑 OR。 如果第一个操作数计算结果为 true，则 C# 不对第二个操作数求值。

Null 合并运算符
此运算符的优先级比下一章节高，比上一章节低。
x ?? y：如果不为 null，则返回 x；否则返回 y。

条件运算符
此运算符的优先级比下一章节高，比上一章节低。
t ? x : y - 如果测试 t 计算结果为 true，则计算并返回 x；否则，计算并返回 y。

赋值和 Lambda 运算符
这些运算符的优先级比下一章节高，比上一章节低。
x = y：赋值。
x += y：递增。 x 值加 y 值，结果存储在 x 中，并返回新值。 如果 x 指定 event，则 y 必须是 C# 作为事件处理程序添加的相应函数。
x -= y：递减。 x 值减 y 值，结果存储在 x 中，并返回新值。 如果 x 指定 event，则 y 必须是 C# 作为事件处理程序删除的相应函数
x *= y：乘法赋值。 x 值乘以 y 值，结果存储在 x 中，并返回新值。
x /= y：除法赋值。 x 值除以 y 值，结果存储在 x 中，并返回新值。
x %= y：余数赋值。 x 值除以 y 值，余数存储在 x 中，并返回新值。
x &= y：AND 赋值。 y 值和 x 值相与，结果存储在 x 中，并返回新值。
x |= y：OR 赋值。 y 值和 x 值相或，结果存储在 x 中，并返回新值。
x ^= y：XOR 赋值。 y 值和 x 值相异或，结果存储在 x 中，并返回新值。
x <<= y：左移赋值。 将 x 值向左移动 y 位，结果存储在 x 中，并返回新值。
x >>= y：右移赋值。 将 x 值向右移动 y 位，结果存储在 x 中，并返回新值。
=>：lambda 声明。

算术溢出
算术运算符（+、-、*、/）的计算结果可能会超出所涉数值类型的可取值范围。 详细信息应参考特定运算符的相关章节，而一般情况下：
整数算术溢出或者引发 OverflowException，或者放弃结果的最高有效位。 整数被零除总是引发 DivideByZeroException。
发生整数溢出时，具体影响视执行上下文而定，上下文可为 checked 或 unchecked。 在 checked 上下文中引发 OverflowException。 在 unchecked 上下文中，放弃结果的最高有效位并继续执行。 因此，C# 让你有机会选择处理或忽略溢出。 默认情况下，算术运算发生在 unchecked 上下文中。
除算术运算以外，整型类型之间的显式转换也会导致溢出（例如，将 long 显式转换成 int），并受到 checked 或 unchecked 执行的约束。 但是，位运算符和移位运算符永远不会导致溢出。
浮点算术溢出或被零除从不引发异常，因为浮点类型基于 IEEE 754，因此可以表示无穷大和 NaN（非数值）。
小数算术溢出总是引发 OverflowException。 小数被零除总是引发 DivideByZeroException。



### 补充 
* . 在C# 和Java里面作用是不一样的：  
  * C#   .   get成员变量，是操作符  
  * Java  .  并不是操作符，Separators  

###### ++x x++  
```csharp
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100;
            int y = 100;
            int r1 = x++;//后置优先级高于前置优先级
            int r2 = ++y;
            Console.WriteLine("{0},{1}",r1,r2);
        }
    }
    
}
```


###### new 操作符  
```csharp
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();//变量声明语句

            Student stu1 = null;//变量声明语句
            stu1 = new Student();//变量赋值语句
        }
    }
    class Student{   }
}
```


###### 引用类型协变
```csharp
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[10];
            object[] objects = null;
            object o = new Student();//隐式转换
            Student haha = (Student) o; //显式转换

            objects = students;
            Student[] manystudent=(Student[]) objects; //引用类型数组协变，值类型不能
            //引用类型所占大小都是一样的，而值类型所占大小不一样，所以值类型没有斜变这种说法

            long l = 0;
            int i = 100;
            l = i;

        }
    }
    class Student{   }
}
```

###### 溢出   
*，+ 溢出   
 * 注意数据类型溢出  
* /，%   
 * 注意0  
 * 注意什么时候是整除，什么时候算术除法     
 * C系列语言遇到/都是整除，小数点去掉  -5/3=-1， python -5//3=-2    
 
###### 左移右移  
```charp
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            x = x >> 32; //左移之前先对该书对32取余  
            Console.WriteLine(x);//1
            x = x >> 33;
            Console.WriteLine(x);//2  33先对32取余为1，相当于左移1位
            int x = 1;
            x = x >> 64;
            Console.WriteLine(x);//1
        }
    }
}
```

###### 字符串比大小
```csharp
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string n1 = "Tim";
            string n2 = "tim";
            Console.WriteLine(n1.CompareTo(n2));//1
        }
    }
}
```

###### is as  
```csharp
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Human h = new Human();
            //Student s = new Student();
            //Console.WriteLine(s is Human);//True
            //Console.WriteLine(s is object);//True

            Human h = new Student();
            Student s = h as Student;//尝试转换，如果不成功则是空  （c# 8.0 以上 pattern match）
        }
    }
    class Human
    {

    }
    class  Student : Human
    {

    }
}
```

###### ??  和  ?.   
```csharp
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "ABC";
            string source = name;
            Console.WriteLine($"hello,{source} !");//hello,ABC !
            string name1 = null;
            string source1 = name1??"stranger";//如果null代替，相当于  source1= name1==null?"stranger":name1;
            Console.WriteLine($"hello,{source1} !");//hello,stranger !

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
            Student student = new Student() { id = 1, name = "Tim" };
            Console.WriteLine(student.id);
            Student student1 = null;
            Console.WriteLine(student1.id);
            Student stu = new Student() { id = 1, name = "Tim" };
        }
    }
    class Human
    {

    }
    class  Student : Human
    {
        public int id;
        public string name;
    }
}
```
