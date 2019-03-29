/*
1.A dictionary is a collection of (key,value) pairs
2.Dictionary class is present in System.Collections.Generic namespace
3.When creating a dictionary, we need to specify the type for key and value
4.Dictionary provides fast lookups for values using keys
5.Keys in the dictionary must be unique
*/
using System;
using System.Collections.Generic;

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

            Customer customer119 = dictionaryCustomers[103];
            Console.WriteLine("ID={0},Name={1},Salary={2}", customer119.ID, customer119.Name, customer119.Salary);
            
            foreach(KeyValuePair<int,Customer> customerKeyValuePair in dictionaryCustomers)
            {
                Console.WriteLine("key={0}", customerKeyValuePair.Key);
                Customer cust = customerKeyValuePair.Value;
                Console.WriteLine("ID={0},Name={1},Salary={2}", cust.ID, cust.Name, cust.Salary);
                Console.WriteLine("------------------------------------------------------");
            }

            foreach (var customerKeyValuePair in dictionaryCustomers)//推荐KeyValuePair<int,Customer>
            {
                Console.WriteLine("key={0}", customerKeyValuePair.Key);
                Customer cust = customerKeyValuePair.Value;
                Console.WriteLine("ID={0},Name={1},Salary={2}", cust.ID, cust.Name, cust.Salary);
                Console.WriteLine("------------------------------------------------------");
            }

            foreach (int key in dictionaryCustomers.Keys)
            {
                Console.WriteLine(key);
            }

            foreach (Customer cust in dictionaryCustomers.Values)
            {
                Console.WriteLine("ID={0},Name={1},Salary={2}", cust.ID, cust.Name, cust.Salary);
            }

            if (!dictionaryCustomers.ContainsKey(customer1.ID))
            {
                dictionaryCustomers.Add(customer1.ID, customer3);
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
