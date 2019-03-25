//Read/Write Properties
//Read Only Properties
//Write Only Properties
//Auto Implemented Properties


using System;

public class Student
{
    private int _id;
    private string _Name;
    private int _passMark = 35;

    public string Email{get;set;}
    public string City{get;set;}

//private string _city;
//private string _email;
//public string Email
//{
//    get
//    {
//        return this._email;
//    }
//    set
//    {
//        this._email = value;
//    }
//}

//public string City
//{
//    get
//    {
//        return this._city;
//    }
//    set
//    {
//        this._city = value;
//    }
//}


    public int PassMark
    {
        get{
            return this._passMark;
        }
    }
    public string Name
    {
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Name cannot be null or empty");
            }
            this._Name = value;
        }
        get
        {
            return string.IsNullOrEmpty(this._Name) ? "No Name" : this._Name;
        }
    }

    public int Id
    {
        set{
            if (value <= 0)
            {
                throw new Exception("Student ID cannot be negative");
            }
            this._id = value;
        }
        get{
            return this._id;
        }
    }
}

public class Program
{
    public static void Main()
    {
        Student C1 = new Student();
        C1.Id = 101;
        C1.Name= "MIKE";
        Console.WriteLine("ID={0}", C1.Id);
        Console.WriteLine("Name={0}", C1.Name);
        Console.WriteLine("PassMark={0}", C1.PassMark);

    }
}
