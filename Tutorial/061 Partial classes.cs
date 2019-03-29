/*
under part1-ConsoleApp1 have four class
Customer.cs
PartialCustomerOne.cs
PartialCustomerTwo.cs
Program.cs
*/
//================================Program.cs================================================
using part1_ConsoleApp1;
using System;
using System.Text;
namespace Program
{
    public class MainClass
    {
        private static void Main()
        {
            Customer C1 = new Customer();
            C1.FirstName = "y";
            C1.LastName = "c";
            string FullName1 = C1.GetFullName();
            Console.WriteLine(FullName1);//y,c


            PartialCustomer C2 = new PartialCustomer();
            C2.FirstName = "y";
            C2.LastName = "c";
            string FullName2 = C2.GetFullName();
            Console.WriteLine(FullName2);//y,c
        }
    }
}
//=========================================Customer.cs==============================
using System;

namespace part1_ConsoleApp1
{
    public class Customer
    {
        private string _firstName;
        private string _lastName;

        public string FirstName
        {
            get{ return _firstName; }
            set{ _firstName = value;}
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string GetFullName()
        {
            return _firstName + "," + _lastName;
        }
    }
}
//=========================================PartialCustomerOne.cs==============================
using System;

namespace part1_ConsoleApp1
{
    public partial class PartialCustomer
    {
        private string _firstName;
        private string _lastName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
    }
}
//=========================================PartialCustomerTwo.cs==============================
using System;

namespace part1_ConsoleApp1
{
    public partial class PartialCustomer
    {
        public string GetFullName()
        {
            return _firstName + "," + _lastName;
        }
    }
}
