using System;

class Circle
{
    static float _PI;
    int _Radius;
    static Circle() //static constructors
    {
        Console.WriteLine("static Constructor called");
        Circle._PI = 3.141F;
      }
    public Circle(int Radius)//instance constructors
    {
        this._Radius = Radius;
        Console.WriteLine("instance Constructor called");
    }
    public static void Print()
    {
        //
    }
    public float CalculateArea()
    {
        return Circle._PI * this._Radius * this._Radius;
    }
}

class Program
{
    public static void Main()
    {
        Circle C1 = new Circle(5);
        float Area1 = C1.CalculateArea();
        Circle.Print();//static && instance 
        Console.WriteLine("Area1 = {0}", Area1);//Area1 = 78.525

        Circle C2 = new Circle(6);
        float Area2 = C2.CalculateArea();
        Console.WriteLine("Area2 = {0}", Area2);//Area2 = 113.076


        /*
         output
            static Constructor called  (one time at firstly)
            instance Constructor called (every time we create a class)
            Area1 = 78.525
            instance Constructor called
            Area2 = 113.076
            Press any key to continue . . .
         */
    }

}


