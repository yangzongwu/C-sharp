/*
TrueForAll()
AsReadOnly()
TrimExcess()
*/

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
                Salary = 5000,
            };
            Customer customer2 = new Customer()
            {
                ID = 102,
                Name = "honn",
                Salary = 5500,
            };
            Customer customer3 = new Customer()
            {
                ID = 103,
                Name = "john",
                Salary = 3400,
            };

            List<Customer> listCustomers = new List<Customer>(100);
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);

            Console.WriteLine(listCustomers.TrueForAll(x => x.Salary > 5000));//False
            Console.WriteLine(listCustomers.TrueForAll(x => x.Salary > 500));//True

            ReadOnlyCollection<Customer> readOnlyCustomer=listCustomers.AsReadOnly();
            //readOnlyCustomer.Add()  wrong
            Console.WriteLine(readOnlyCustomer.Count());//3

            Console.WriteLine(listCustomers.Capacity);//100
            listCustomers.TrimExcess();
            Console.WriteLine(listCustomers.Capacity);//3
        }
    }
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
 }
