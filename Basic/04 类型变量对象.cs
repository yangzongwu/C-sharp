什么是类型
类型在C#语言中的作用
C#语言的类型系统
变量，对象与内存

什么是类型：又名数据类型（DATA TYPE）
强类型语言与弱类型语言的比较

C#是强类型语言
dynamic可以模仿弱类型语言
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic myVar = 100;
            Console.WriteLine(myVar);
            myVar = "OK";
            Console.WriteLine(myVar);
        }
    }
}

类型作用：
存储此类型变量所需要的内存空间大小
此类型的值科比爱哦是的最大最小值范围
此类型所包含的成员（如方法，属性，事件等）
此类型由何基类派生而来
程序运行的时候，此类型的变量在分配在内存的什么位置
此类型所允许的操作


C#的语言五大数据类型
类（ class）:Window,Form,Console,String  // class
结构体（structures）:Int32,Int64,Single,Double  // struct
枚举（Enumerations）:HorizontalAlignment,Visibility //enum
接口（Interfaces）
委托（Delegates）

object{
  引用类型（reference type）{类，接口，委托}
  值类型（value type）{结构体，枚举}
}

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Type myType = typeof(Form);
            Console.WriteLine(myType.FullName);
            Console.WriteLine(myType.IsClass);
        }
    }
}


变量、对象与内存
变量表示了存储位置，并且每个变量都有一个类型，已决定什么样的类型可以存进变量
变量一共由7种：静态变量，实例变量（成员变量，字段），数组元素，值参数，引用参数，输出形参，局部变量
变量的声明：(有效的修饰组合（可选），类型，变量名，初始化器（可选）)
int a;
a=100;
public int b;
b=200;
int c=a+b;
console.WriteLine(c)

值类型的变量：值类型没有实例，所谓的”实例“与变量合二为一
引用类型的变量与实例：引用类型变量与实例的关系：引用类型变量里存储的数据是对象的内存地址

局部变量是在stack上分配内存
变量的默认值（本地变量必须赋值）
常量（值不能改变，const int x=100;）
装箱与拆箱

