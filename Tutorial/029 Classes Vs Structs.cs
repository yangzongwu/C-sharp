/*
Struct cannot have a default constructor (a constructor without parameters) or a destructor.
Structs are value types and are copied on assignment. 
Structs are value types while classes are reference types.
Structs can be instantiated without using a new operator.
A struct cannot inherit from another struct or class, and it cannot be the base of a class. All structs inherit directly 
from System.ValueType, which inherits from System.Object.
Struct cannot be a base class. So, Struct types cannot abstract and are always implicitly sealed.
Abstract and sealed modifiers are not allowed and struct member cannot be protected or protected internals.
Function members in a struct cannot be abstract or virtual, and the override modifier is allowed only to the override 
methods inherited from System.ValueType.
Struct does not allow the instance field declarations to include variable initializers. But, static fields of a struct 
are allowed to include variable initializers.
A struct can implement interfaces.
A struct can be used as a nullable type and can be assigned a null value.
● class是引用类型，struct是值类型，所有他有值类型和引用类型的区别特征，参见《C#值类型和引用类型的区别》
● class的实例创建是在托管堆上，struct实例创建是在栈上
● class实例的赋值，赋的是引用地址，struct实例的赋值，赋的是值
● class作为参数类型传递，传递的是引用地址，struct作为参数类型传递，传递的是值
● class 的默认访问权限是private，而struct的的默认访问权限public
● struct不能显式地声明无参数构造函数（默认构造函数）或析构函数，也就是struct声明的构造函数必须带有参数；
而class可以显式声明无参数构造函数。（由于struct的副本由编译器自动创建和销毁，因此不需要使用默认构造函数和析构函数。
实际上，编译器通过为所有字段赋予默认值（参见默认值表（C# 参考））来实现默认构造函数）
● 如果class中只声明了一个有参数的构造函数，则用new关键字创建实例时不能再无参数构造函数（默认构造函数），否则会出现
”XXX不包含0个参数的构造函数"的编译错误，这句话的意思表明class中除非没有一个构造函数，否则声明了什么构造函数，就只能
用什么构造函数。
而struct中由于只能声明带参数的构造函数，当创建实例时
● class创建实例必须用new关键字，而struct可以用new，也可以不用new，区别在于用new生成的struct中，struct的成员函数是有初始值的。
● class支持继承，struct不支持继承，但支持接口。
● class偏向于"面向对象",用于复杂、大型数据，struct偏向于"简单值"，比如小于16字节，结构简单
● class的成员变量可以在声明的时候赋初值，而在struct声明中，除非字段被声明为 const 或 static，否则无法初始化。
*/


using System;

public class Customer
{
    public int ID{ get; set; }
    public String Name { get; set; }
}

public class Program
{
    public static void Main()
    {
       int i=0;
        if (i == 0)
        {
            int j = 20;
            Customer C1 = new Customer();
            C1.ID = 101;
            C1.Name = "MIKE";
        }
        /*
         * stack (object reference variable): i=10,j=20,c1
         * heap  (actual customer object):ID=101,Name="mike"
         */
    }
}




using System;

public class Customer
{
    public int ID{ get; set; }
    public String Name { get; set; }
}

public class Program
{
    public static void Main()
    {
        int i = 10;
        int j = i;
        j = j + 1;
        Console.WriteLine("{0},{1}", i, j);
        Customer C1 = new Customer();
        C1.ID = 101;
        C1.Name = "mike";
        Customer C2 = C1;
        C2.Name = "mary";
        C2.ID = 1;
        Console.WriteLine("{0},{1}", C1.Name, C1.ID);//mary,1
    }
}



using System;

public struct Customer
{
    public int ID{ get; set; }
    public String Name { get; set; }
}

public class Program
{
    public static void Main()
    {
        int i = 10;
        int j = i;
        j = j + 1;
        Console.WriteLine("{0},{1}", i, j);
        Customer C1 = new Customer();
        C1.ID = 101;
        C1.Name = "mike";
        Customer C2 = C1;
        C2.Name = "mary";
        C2.ID = 1;
        Console.WriteLine("{0},{1}", C1.Name, C1.ID);//mike,101
    }
}



public struct Customer
{
    public int ID{ get; set; }
    public String Name { get; set; }
    public ~Customer() { }//wrong
}
public class Customer
{
    public int ID{ get; set; }
    public String Name { get; set; }
    public ~Customer() { }//ok
}
