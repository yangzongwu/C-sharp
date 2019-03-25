using System;

public class Student
{
    public int ID;
    public string Name;
    public int PassMark = 35;
}

public class Program
{
    public static void Main()
    {
        Student C1 = new Student();
        C1.ID = -101;
        C1.Name = null;
        C1.PassMark = 0;
        Console.WriteLine("ID={0} && Name ={1} && PassMark={2}", C1.ID, C1.Name, C1.PassMark);
        //ID=-101 && Name = && PassMark=0
    }
}



using System;

public class Student
{
    private int _id;
    private string _Name;
    private int _passMark = 35;

    public int GetPassMark()
    {
        return this._passMark;
    }
    
    public void SetName(string Name)
    {
        if (string.IsNullOrEmpty(Name))
        {
            throw new Exception("Name cannot be null or empty");
        }
        this._Name = Name;
    }
    public string GetName()
    {
        return string.IsNullOrEmpty(this._Name) ? "No Name" : this._Name;
    }

    public void SetID(int Id)
    {
        if (Id <= 0)
        {
            throw new Exception("Student ID cannot be negative");
        }
        this._id = Id;
    }
    public int GetId()
    {
        return this._id;
    }
}

public class Program
{
    public static void Main()
    {
        Student C1 = new Student();
        //C1.SetID(-101);//Unhandled Exception: System.Exception: Student ID cannot be negative
        C1.SetID(101);
        C1.SetName("MIKE");
        Console.WriteLine("ID={0}", C1.GetId());//ID=101
        Console.WriteLine("Name={0}", C1.GetName());// no null or empty
        Console.WriteLine("PassMark={0}", C1.GetPassMark());//read only

    }
}
