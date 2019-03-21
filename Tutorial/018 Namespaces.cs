An namespage can contain 
1.Another namespace
2.class
3.interfase
4.struct
5.enum
6.delegate
//====================================ProjectA.TeamA===================================================
namespace ProjectA
{
    namespace TeamA
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Team a Print Method");
            }
        }
    }
}
//=====================================ProjectA.TeamB==================================================

namespace ProjectA
{
    namespace TeamB
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Team b Print Method");
            }
        }
    }
}
//===========================================Main project============================================
using System;
using ProjectA.TeamA;// 需要add reference

namespace part1_ConsoleApp1
{
    class Program
    {
        public static void Main()
        {
            ClassA.Print();
            ProjectA.TeamA.ClassA.Print();
        }
    }
}
//================================================================================================================
using System;
using PATA=ProjectA.TeamA;
using PATB=ProjectA.TeamB;

namespace part1_ConsoleApp1
{
    class Program
    {
        public static void Main()
        {
            PATB.ClassA.Print();
            PATB.ClassA.Print();
        }
    }
}
//=======================================================================================
