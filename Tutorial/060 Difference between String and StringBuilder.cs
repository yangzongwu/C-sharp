/*
System.String is immutable
System.Text.StringBuilder is mutable
*/

using System;
using System.Text;
namespace Pragim
{
    public class MainClass
    {
        private static void Main()
        {
            string userString = "C#";
            userString += "video";
            userString += "Tutorial";
            Console.WriteLine(userString);
            /*
             stack: userString
             Heap: C#, C# video,C# video Tutorial
             (three objects in heap not clean,C#, C# video are garbages)
             */

            StringBuilder str1 = new StringBuilder("C#");
            str1.Append(" video");
            str1.Append(" Tutorial");
            Console.WriteLine(str1.ToString());//C# video Tutorial
            /*
             stack: userString
             Heap: C# video Tutorial
             (only one objects in heap no garbages)
             */

            string userstring1 = string.Empty;
            for(int i = 1; i < 10000; i++)
            {
                userString += i.ToString() + " ";
            }
            Console.WriteLine(userstring1);//will create 10000 object, 9999 just garbages
        }
    }
}

