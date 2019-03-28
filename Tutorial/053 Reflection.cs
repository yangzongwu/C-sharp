using System;
using System.Collections.Generic;
using System.Reflection;

namespace Pragim
{
    public class MainClass
    {
        private static void Main()
        {
            //Type T = Type.GetType("Pragim.Customer");
            //Type T = typeof(Customer);//the same with the above
            Customer C1 = new Customer();//the same with the above
            Type T=C1.GetType();

            Console.WriteLine("Properties in Customers class");
            Console.WriteLine("FullName={0}", T.FullName);//FullName = Pragim.Customer
            Console.WriteLine("Just the Namespace={0}", T.Namespace);//Just the Namespace = Pragim
            PropertyInfo[] Properties = T.GetProperties();
            foreach (PropertyInfo property in Properties)
            {
                Console.WriteLine(property.PropertyType.Name+" "+ property.Name);
                //Int32 Id
                //String Name
            }
            Console.WriteLine();

            Console.WriteLine("Methods in Customers class");
            MethodInfo[] methods = T.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Name + " " + method.Name);
                /*
                 * Int32 get_Id
                    Void set_Id
                    String get_Name
                    Void set_Name
                    Void PrintID
                    Void PrintName
                    String ToString
                    Boolean Equals
                    Int32 GetHashCode
                    Type GetType
                 */
            }
            Console.WriteLine();
            Console.WriteLine("Constructors in Customers class");
            ConstructorInfo[] Constructors = T.GetConstructors();
            foreach (ConstructorInfo Constructor in Constructors)
            {
                Console.WriteLine(Constructor.ToString());
                //Void .ctor(Int32, System.String)
                //Void.ctor()
            }
        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Customer(int ID, string Name)
        {
            this.Id = ID;
            this.Name = Name;
        }
        public Customer()
        {
            this.Id = -1;
            this.Name = string.Empty;
        }
        public void PrintID()
        {
            Console.WriteLine("ID={0}", this.Id);
        }
        public void PrintName()
        {
            Console.WriteLine("Name={0}", this.Name);
        }
    }
}
