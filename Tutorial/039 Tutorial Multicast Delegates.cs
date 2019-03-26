using System;


public delegate void SampleDelegate();

class Program
{
    public static void Main()
    {
    
    //1==============================================================================
        SampleDelegate del = new SampleDelegate(SampleMethodeOne);

        del += SampleMethodeTwo;
        del += SampleMethodeThree;
        del();
        //SampleMethodeOne Invoked
        //SampleMethodeTwo Invoked
        //SampleMethodeThree Invoked
        del += SampleMethodeTwo;
        del += SampleMethodeThree;
        del -= SampleMethodeTwo;
        del();
        //SampleMethodeOne Invoked
        //SampleMethodeThree Invoked
        
    //2==============================================================================  
        SampleDelegate del = new SampleDelegate(SampleMethodeOne);
        del();//SampleMethodeOne Invoked

        //muti
        SampleDelegate del1, del2, del3, del4;
        del1 = new SampleDelegate(SampleMethodeOne);
        del2 = new SampleDelegate(SampleMethodeTwo);
        del3 = new SampleDelegate(SampleMethodeThree);

        del4 = del1 + del2 + del3;
        del4();
        //SampleMethodeOne Invoked
        //SampleMethodeTwo Invoked
        //SampleMethodeThree Invoked

        del4 = del1 + del2 + del3-del2;
        del4();
        //SampleMethodeOne Invoked
        //SampleMethodeThree Invoked
    }
    public static void SampleMethodeOne()
    {

        Console.WriteLine("SampleMethodeOne Invoked");
    }
    public static void SampleMethodeTwo()
    {
        Console.WriteLine("SampleMethodeTwo Invoked");
    }
    public static void SampleMethodeThree()
    {
        Console.WriteLine("SampleMethodeThree Invoked");
    }
}

//=======================================================
using System;


public delegate int SampleDelegate();

class Program
{
    public static void Main()
    {
        SampleDelegate del = new SampleDelegate(SampleMethodeOne);
        del += SampleMethodeTwo;

        int DelegateReturnValue=del();
        Console.WriteLine(DelegateReturnValue);//2  by the last function
    }
    public static int SampleMethodeOne()
    {

        return 1;
    }
    public static int SampleMethodeTwo()
    {
        return 2;
    }
}
//===================================================================================================
using System;


public delegate void SampleDelegate(out int Integer);

class Program
{
    public static void Main()
    {
        SampleDelegate del = new SampleDelegate(SampleMethodeOne);
        del += SampleMethodeTwo;

        int DelegateOutputParameterValue=-1;
        del(out DelegateOutputParameterValue);
        Console.WriteLine(DelegateOutputParameterValue);//2  by the last function
    }
    public static void SampleMethodeOne(out int Number)
    {

        Number= 1;
    }
    public static void SampleMethodeTwo(out int Number)
    {
        Number= 2;
    }
}
