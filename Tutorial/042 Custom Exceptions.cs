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
