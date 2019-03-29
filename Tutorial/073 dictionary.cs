/*
TryGetValue()
Count()
Remove()
Clear()
Using LINQ extension method with Dictionary
Different ways to convert an array into a dictionary
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 5000
            };
            Customer customer2 = new Customer()
            {
                ID = 102,
                Name = "honn",
                Salary = 5500
            };
            Customer customer3 = new Customer()
            {
                ID = 103,
                Name = "john",
                Salary = 3400
            };

            Dictionary<int, Customer> dictionaryCustomers = new Dictionary<int, Customer>();
            dictionaryCustomers.Add(customer1.ID, customer1);
            dictionaryCustomers.Add(customer2.ID, customer2);
            dictionaryCustomers.Add(customer3.ID, customer3);
            
            //TryGetValue
            Customer cust;
            if(dictionaryCustomers.TryGetValue(1201, out cust))
            {
                Console.WriteLine("ID={0},Name={1},Salary={2}", cust.ID, cust.Name, cust.Salary);
            }
            else
            {
                Console.WriteLine("The key is not found");
            }

            //Count
            Console.WriteLine("Total Item={0}", dictionaryCustomers.Count);//Total Item=3
            Console.WriteLine("Total Item={0}", dictionaryCustomers.Count());//Total Item=3
            Console.WriteLine("Total Item={0}", dictionaryCustomers.Count(kvp=>kvp.Value.Salary> 4000));//Total Item=2

            dictionaryCustomers.Remove(101);
            dictionaryCustomers.Remove(10122);

            dictionaryCustomers.Clear();


        }

        
    }
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }

}
//===================================================================================================
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 5000
            };
            Customer customer2 = new Customer()
            {
                ID = 102,
                Name = "honn",
                Salary = 5500
            };
            Customer customer3 = new Customer()
            {
                ID = 103,
                Name = "john",
                Salary = 3400
            };

            Customer[] customers = new Customer[3];
            customers[0] = customer1;
            customers[1] = customer2;
            customers[2] = customer3;
            Dictionary<int,Customer> dict=customers.ToDictionary(cust => cust.ID, cust => cust);
            foreach(KeyValuePair<int,Customer> kvp in dict)
            {
                Console.WriteLine("Key={0}", kvp.Key);
                Customer cust = kvp.Value;
                Console.WriteLine("ID={0},Name={1},Salary={2}", cust.ID, cust.Name, cust.Salary);
            }

            List<Customer> customerslist = new List<Customer>();
            customerslist.Add(customer1);
            customerslist.Add(customer2);
            customerslist.Add(customer3);
            Dictionary<int, Customer> dictlsit = customers.ToDictionary(cust => cust.ID, cust => cust);
            foreach (KeyValuePair<int, Customer> kvp in dictlsit)
            {
                Console.WriteLine("Key={0}", kvp.Key);
                Customer cust = kvp.Value;
                Console.WriteLine("ID={0},Name={1},Salary={2}", cust.ID, cust.Name, cust.Salary);
            }
        }
    }
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
