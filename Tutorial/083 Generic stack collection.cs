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

            Stack<Customer> stackCustomers = new Stack<Customer>(100);
            stackCustomers.Push(customer1);
            stackCustomers.Push(customer2);
            stackCustomers.Push(customer3);

            Customer c1= stackCustomers.Pop();
            Console.WriteLine(c1.ID.ToString());//103
            Console.WriteLine(stackCustomers.Count);//2

            foreach(Customer c in stackCustomers)
            {
                Console.Write("{0},", c.ID);//102,101,

            }
            Console.WriteLine();

            Console.WriteLine(stackCustomers.Peek().ID);//102
            Console.WriteLine(stackCustomers.Peek().ID);//102 still

            if (stackCustomers.Contains(customer1))
            {
                Console.WriteLine("contains customer1");
            }
            else
            {
                Console.WriteLine("not contains customer1");
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
