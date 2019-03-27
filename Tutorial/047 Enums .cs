/*
1.Enums are enumerations
2.Enums are strongly typed constants
3.The default underlying type ofan enum is int
4.The default value for first element is ZERO and gets incremented by 1.
5.It is possible to customize the underlying type and values.
6.Enums are value types
7.Enum keyword(all small letters)is used to create enumerations. where Enum
class,contains static GetValue() and GetName() methods which can be used to 
list Enum underlying type values and Names
*/
using System;

public class Enums
{
    public static void Main()
    {
        int[] Values=(int[])Enum.GetValues(typeof(Gender));
        foreach(int value in Values)
        {
            Console.WriteLine(value);
        }
        string[] Names = Enum.GetNames(typeof(Gender));
        foreach (string name in Names)
        {
            Console.WriteLine(name);
        }
    }
}

//public enum Gender : short --ok.can change type
public enum Gender
{
    Unkonw, // then 0,1,2
    //Unkonw=1, then 1,2,3, can be any number
    Male,
    Female
}
//=================================================================
using System;

public class Enums
{
    public static void Main()
    {
        Gender gender = 3;
        //can not do 
        Gender gender = Season.Winter;
        //Cannot implicitly convert type 'Season' to 'Gender'.An explicit conversion exists
        Gender gender = (Gender)Season.Winter;
    }
}

public enum Gender
{
    Unkonw=1,
    Male=2,
    Female=3,
}

public enum Season
{
    Winter = 1,
    Spring = 2,
    Summer = 3,
}
