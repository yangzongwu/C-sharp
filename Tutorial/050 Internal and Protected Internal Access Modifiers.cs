/* 
Internal  anywhere with in the containing assembly
Protected Internal  anywhere with in the containing assembly,and from within a derived class in any another assembly
internal也是一各类型/成员修饰符（被修饰的类型或者成员称为内部类型或成员），只是它所修饰的类只能在同一个程序集中被访问，而同一个
程序集表示同一个dll程序集或同一个exe程序集。在vs中一个项目会生成一个dll文件，因此这个dll或这个项目也就是一个程序集。 
*/


//===project 1===
using System;

namespace ProjectA
{
    public class Class1
    {
        internal int ID = 101; 
     }
    public class Class2
    {
        public void SampleMethod()
        {
            Class1 A1 = new Class1();
            Console.WriteLine(A1.ID);
        }
    }
}
//===project 2===
using System;
using Class1;

namespace ProjectB
{
    public class ClassB
    {
        public void Print()
        {
            Class1 A1 = new Class1();
            A1.ID = 101; //wrong
        }  
    }
}
