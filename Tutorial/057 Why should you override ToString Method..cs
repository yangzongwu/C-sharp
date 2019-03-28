using System;

namespace Pragim
{
    public class MainClass
    {
        private static void Main()
        {
           int Number=10;
            Console.WriteLine(Number.ToString());
            Customer C1 = new Customer();//10
            C1.FirstName = "mike";
            C1.LastName = "john";
            Console.WriteLine(C1.ToString());
            Console.WriteLine(Convert.ToString(C1));//the same with above
            //no overwrite:Pragim.Customer 
            //so need overwrite :john,mike
        }
    }
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            //return base.ToString();
            return this.LastName + "," + this.FirstName;
        }
    }
}

