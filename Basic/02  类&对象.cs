类三大成员：
属性 
方法
事件

类与对象的关系：
1：对象也叫实例，是类经过“实例化”后得到的内存中的实体
2：依照类，我们可以创建对象，这就是‘实例化’
3：使用new操作符创建类的实例


使用new操作符创建类的实例
using System.Windows.Forms;
namespace classandinstance
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Form()).ShowDialog();
        }
    }
}

引用变量
using System.Windows.Forms;
namespace classandinstance
{
    class Program
    {
        static void Main(string[] args)
        {
            Form myForm;
            myForm = new Form();
            myForm.Text = "My Form";
            myForm.ShowDialog();
        }
    }
}

多个变量指向同一个实列
using System.Windows.Forms;
namespace classandinstance
{
    class Program
    {
        static void Main(string[] args)
        {
            Form myForm1;
            Form myForm2;
            myForm1 = new Form();
            myForm2= myForm1;
            myForm1.Text = "My Form";
            myForm2.ShowDialog();
        }
    }
}


类的三大成员：
属性 Property
存储数据，组合起来表示类或对象当前的状态
方法 Method
由C语言中的函数进化而来，表示类或者对象“能做什么”
事件 Event
类或对象通知其他类或对象的机制，为C#所特有
使用MSDN文档（选择类按 F1 键）

namespace classandinstance
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = Math.Sin(3);
            Console.WriteLine(x);
        }
    }
}




namespace classandinstance
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = Math.Sin(3);
            Console.WriteLine(x);
        }
    }
}


静态成员与实例成员
  静态：
  Console.WriteLine(x);
  实例：
  Form myForm = new Form();
  myForm.Text = "My Form";
  myForm.ShowDialog();
