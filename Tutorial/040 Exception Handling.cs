using System;
using System.IO;

class Program
{
    public static void Main()
    {
        try
        {
            StreamReader streamReader = new StreamReader(@"C:\Users\yzw\Desktop\11.txt");
            Console.WriteLine(streamReader.ReadToEnd());
            streamReader.Close();
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(ex.StackTrace);
        } 
    }
}
//============================================================================================
using System;
using System.IO;

class Program
{
    public static void Main()
    {
        try
        {
            StreamReader streamReader = new StreamReader(@"C:\Users\yzw\Desktop\11.txt");
            Console.WriteLine(streamReader.ReadToEnd());
            streamReader.Close();
        }
        catch(FileNotFoundException ex)//can not handle path wrong info.
        {
             Console.WriteLine("Please check if the file {0} exits", ex.FileName);//特有filename
        } 
    }
}
//==============================================================================================
using System;
using System.IO;

class Program
{
    public static void Main()
    {
        try
        {
            StreamReader streamReader = new StreamReader(@"C:\Users\yzdfw\Desktop\11.txt");
            Console.WriteLine(streamReader.ReadToEnd());
            streamReader.Close();
        }
        catch(FileNotFoundException ex)//specific exception
        {
            //Log the details to the DB
            Console.WriteLine("Please check if the file {0} exits", ex.FileName);
        }
        catch(Exception ex)//general exception
        {
            Console.WriteLine(ex.Message);
        }  
    }
}
//=======================================================================================================
using System;
using System.IO;

class Program
{
    public static void Main()
    {
        StreamReader streamReader = null;
        try
        {
            streamReader = new StreamReader(@"C:\Users\yzw\Desktop\11.txt");
            Console.WriteLine(streamReader.ReadToEnd());
        }
        catch(FileNotFoundException ex)//specific exception
        {
            //Log the details to the DB
            Console.WriteLine("Please check if the file {0} exits", ex.FileName);
        }
        catch(Exception ex)//general exception
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            if (streamReader != null)
            {
                streamReader.Close();
            }
            Console.WriteLine("Finally Block");
        }
    }
}
