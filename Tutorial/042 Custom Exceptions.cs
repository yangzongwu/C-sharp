/*
Custom Exception steps
1.Create a class that derives from System.Exception class.As a convention,end the 
class name with Exception suffic,All .NET exceptions end with, exception suffix.

2.Provide a public constructor,taht takes in a string parameter.This constructor
simply passes the string parameter,to the base exception class constructor.

3.Using innerExceptions,you can also track back the original exception,If you want to
provide this capability for your custom exception class, then overload the constructor accordingly

r.If you want your Exception class object to work across application domains,then the 
object must be serializable.To make you exception class serializable mark it with Serializable
attribute and provide a constructor that invokes the base Exception class constructor that
takes in SerializetionInfo and StreamingContext object as parameters.

*/


/*
I have an asp.net web application
the application should allow the user to have only one logged in session
if hte user is already loggin , and if he opens another brower window and tries to 
login again, the application should throw an error stating he is already logged in 
another browers window
*/



using System;
using System.IO;
using System.Runtime.Serialization;

public class CustomExceptionsDemo
{
    public static void Main()
    {
        try
        { //throw new FileNotFoundException("File XYZ is not found");
            throw new UserAlreadyLoggedInException("user is logged in");

        }
       catch(UserAlreadyLoggedInException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

[Serializable]
public class UserAlreadyLoggedInException : Exception
{
    public UserAlreadyLoggedInException() : base()
    {

    }
    public UserAlreadyLoggedInException(string message) : base(message)
    {

    }
    public UserAlreadyLoggedInException(string message, Exception innerException) : base(message, innerException)
    {

    }
    public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context) : base(info, context)
    {

    }
}
