类和命名空间是放在类库里面
命名空间：namespace
类：Program，Console

using System;
namespace Helloword
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HELLO");
        }
    }
}



类库引用
DLL引用（黑盒引用，无源代码）
项目引用（白河引用，有源代码）


DLL引用第三方（黑盒引用，无源代码）（代码有问题，依赖关系，本类也会有问题）
references -->Add (例:
MyLibrary.dll 包含Tools命名空间
Tools命名空间包含Calculator类
Calculator类包含Add方法
)

using System;
namespace Helloword
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HELLO");
            double result=Tools.Calculator.Add(1,2,3,4);
            Console.WriteLine(result);
        }
    }
}




引用系统class
using System.Windows.Forms;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Form form = new Form();
            form.ShowDialog();
        }
    }
}

NuGet
某一些类class必须引用了底层class的才可以引用该class，可以采用NuGet一次性全部引用


项目引用（白河引用，有源代码）
solution -->Add exist solution 
再去references 选上
(例:
MyLibrary.dll 包含Tools命名空间
Tools命名空间包含Calculator类
Calculator类包含Add方法
)
using System;
using Tools
namespace Helloword
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HELLO");
            double result=Tools.Calculator.Add(1,2,3,4);
            Console.WriteLine(result);
        }
    }
}


依赖关系也就耦合关系
高类聚，低耦合

UML类图（类和类之间的关系）
