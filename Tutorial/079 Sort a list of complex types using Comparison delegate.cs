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
            Customer customer4 = new Customer()
            {
                ID = 104,
                Name = "johen",
                Salary = 3430,
            };



            List<Customer> listCustomers = new List<Customer>();
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);
            listCustomers.Add(customer4);

            //way 1 need a private method
            Comparison<Customer> customerComparer = new Comparison<Customer>(CompareCustomer);
            listCustomers.Sort(customerComparer);
            foreach(Customer c in listCustomers)
            {
                Console.Write("{0},", c.ID);//101,102,103,104,
            }
            Console.WriteLine();

            //way2
            listCustomers.Sort(delegate(Customer c1,Customer c2) { return c1.ID.CompareTo(c2.ID); });
            foreach (Customer c in listCustomers)
            {
                Console.Write("{0},", c.ID);//101,102,103,104,
            }
            Console.WriteLine();

            //way3
            listCustomers.Sort((x,y)=>x.ID.CompareTo(y.ID));
            foreach (Customer c in listCustomers)
            {
                Console.Write("{0},", c.ID);//101,102,103,104,
            }
            Console.WriteLine();


        }
        private static int CompareCustomer(Customer x,Customer y)
        {
            return x.ID.CompareTo(y.ID);
        }
    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
 }
