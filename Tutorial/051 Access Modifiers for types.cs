/*
private default for type members
internal default for types
*/


using System;
namespace AssembleOne
{
    public class AssembleOneClass//element defind under namespace can not be private, protect
    {
        public void Print()
        {
            Console.WriteLine("hello");
        }
    }
}
//--------------------------------------------------
using System;
using AssembleOne;

namespace AssemblyTwo
{
    public class AssemblyTwoClass
    {
        public void Test()
        {
            AssembleOne.AssembleOneClass instance = new AssembleOneClass();
            instance.Print();//OK
        }
    }
}
//==============================================================================
using System;


namespace AssembleOne
{
    (internal) class AssembleOneClass
    //element defind under namespace can not be private, protect
    // if no , default internal
    {
        public void Print()
        {
            Console.WriteLine("hello");
        }
    }
}

//--------------------------------------------------------
using System;
using AssembleOne;

namespace AssemblyTwo
{
    public class AssemblyTwoClass
    {
        public void Test()
        {
            AssembleOne.AssembleOneClass instance = new AssembleOneClass();
            //wrong as AssembleOneClass is internal
            instance.Print();
        }
    }
}
