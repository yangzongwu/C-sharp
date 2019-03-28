using System;
using System.Collections.Generic;
using System.Reflection;

namespace Pragim{
    public class MainClass{
        private static void Main(){
            bool Equal = Calculator.AreEqual(1, 2);
            //bool Equal = Calculator.AreEqual("1","1");//how to deal with this?
            if (Equal){
                Console.WriteLine("equal");
            }
            else{
                Console.WriteLine("not equal");
            }
        }
    }

    public class Calculator
    {
        public static bool AreEqual(int value1, int value2)
        {
            return value1==value2;
        }
    }
}

//===========================================================
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Pragim{
    public class MainClass{
        private static void Main(){
            bool Equal = Calculator.AreEqual("1","1");
            if (Equal){
                Console.WriteLine("equal");
            }
            else {
                Console.WriteLine("not equal");
            }
        }
    }

    public class Calculator{
        public static bool AreEqual(object value1, object value2)
        //boxing too much
        //bool Equal = Calculator.AreEqual(1,"1"); not showing wrong issue
        {
            return value1==value2;
        }
    }
}
//=========================================================================
using System;

namespace Pragim{
    public class MainClass{
        private static void Main(){
            //bool Equal = Calculator.AreEqual(1, 2);
            bool Equal = Calculator.AreEqual<string>("1","1");
            if (Equal){
                Console.WriteLine("equal");
            }
            else{
                Console.WriteLine("not equal");
            }
        }
    }

    public class Calculator{
        public static bool AreEqual<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }
}
