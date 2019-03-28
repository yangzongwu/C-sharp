using System;

namespace Pragim
{
    public class MainClass
    {
        private static void Main()
        {
            Customer C1 = new Customer();
            string str = C1.ToString();
            Console.WriteLine(str);//Pragim.Customer
            string str1 = Convert.ToString(C1);
            Console.WriteLine(str1);//Pragim.Customer

            Customer C2 = null;
            string str11 = C2.ToString();
            Console.WriteLine(str11);//issue
            string str12 = Convert.ToString(C2);
            Console.WriteLine(str12);//Pragim.Customer

            // Convert.ToString() handles null,while ToString doesn't and throws a NULL reference exception.

        }
    }
    public class Customer
    {
       public string Name { get; set; }
    }
}
