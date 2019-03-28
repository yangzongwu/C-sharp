/*
Obsolete
WebMethod
Serializable
*/

using System;
using System.Collections.Generic;

public class Calculator
{

    /*
     * [Obsolete]
     * [Obsolete("use Add(Add(List<int> Numbers)) Method")]
     * [Obsolete("use Add(Add(List<int> Numbers)) Method"),ture]
     * 
     * 查看定义，该属性是继承Attribute，这样用法就是直接标在函数或者成员上面，并用“[]”包起来。
     * 该特性有三种构造函数，第二种常用，就是让函数提示过时，同时里面有message提示信息。用法就
     * 是上面第一张图那样，让函数本身“过时”，给了一个警告提，同时鼠标移上去时，会提示message的
     * 信息。第三种构造函数，就是加了error，标记是现实成“警告”（可以编译通过），还是“错误”（无
     * 法编译通过）。
     * 
     * 这个特性，一般写接口的人会使用到，在接口的版本更新后，如果替换了新接口，但是又想老程序能使
     * 用时，一般保留老接口的代码。不过这里就有问题了，接下来新使用的程序，应该让他们用新接口而不
     * 是用老接口：如果说写在文档里面说明这个情况，但是好多人是连接口文档都不看的，直接dll引用就开
     * 始写代码的；如果写在注释里面？那更加不行，一般没报错，是很少有人去看注释的。所以这时候就得
     * 用特性了，使用这个特性，写代码的时候就直接编译器提示了，使用者全部都会看到这个提示。（unity
     * 经常用这个特性提示每次更新版本后丢弃的老属性，不过现在国内绝大部分公司，都是直接删掉老函数，
     * 然后拉分支来处理的，这样导致后期一大堆分支，维护很麻烦）
     */
    [Obsolete("use Add(Add(List<int> Numbers)) Method")]
    public static int Add(int FirstNumber,int SecondNumber)
    {
        return FirstNumber + SecondNumber;
    }
    public static int Add(int FirstNumber, int SecondNumber,int ThirdNumber)
    {
        return FirstNumber + SecondNumber+ThirdNumber;
    }
    public static int Add(List<int> Numbers)
    {
        int Sum = 0;
        foreach(int Number in Numbers)
        {
            Sum += Number;
        }
        return Sum;
    }
}

public class Mainclass
{
    private static void Main()
    {
        Calculator.Add(10, 20);
        Calculator.Add(10, 20, 30);
    }
}
