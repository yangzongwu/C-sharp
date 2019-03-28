using System;

namespace Pragim
{
    public class MainClass
    {
        private static void Main()
        {
            //early binding
            Customer C1 = new Customer();
            string fullName = C1.GetFullName("c", "y");
            Console.WriteLine("FullName={0}", fullName);
        }
    }

    public class Customer
    {
        public string GetFullName(string FN, string LN)
        {
            return FN + " " + LN;
        }
    }
}
//=======================================================================
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Pragim
{
    public class MainClass
    {
        private static void Main()
        {
            //late binding(when we do now know the Customer class type)
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            Type customerType=executingAssembly.GetType("Pragim.Customer");
            object customerInstance = Activator.CreateInstance(customerType);
            MethodInfo getFullNameMethod=customerType.GetMethod("GetFullName");
            string[] parameters = new string[2];
            parameters[0] = "cd";
            parameters[1] = "da";

            string fullName=(string)getFullNameMethod.Invoke(customerInstance, parameters);
            Console.WriteLine("Full Name={0}", fullName);
        }
    }

    public class Customer
    {
        public string GetFullName(string FN, string LN)
        {
            return FN + " " + LN;
        }
    }
}

