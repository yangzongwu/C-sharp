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

            foreach(Customer c in listCustomers)
            {
                Console.Write("{0},", c.ID);//101,102,103,104,
            }
            Console.WriteLine();

            listCustomers.Sort();
            foreach (Customer c in listCustomers)
            {
                Console.Write("{0},", c.ID);//103,104,101,102,
            }
            Console.WriteLine();


            //seconde way to sort by own class
            SortByName sortByName = new SortByName();
            listCustomers.Sort(sortByName);
            foreach (Customer c in listCustomers)
            {
                Console.Write("{0},", c.Name);//honn,johen,john,Mark,
            }
            Console.WriteLine();

        }
    }
    public class SortByName : IComparer<Customer>
    {
        public int Compare(Customer x,Customer y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
    public class Customer :IComparable<Customer>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public int CompareTo(Customer other)
        {
            //if(this.Salary > other.Salary){ return 1; }
            //else if(this.Salary < other.Salary) { return -1; }
            //else { return 0; }
            return this.Salary.CompareTo(other.Salary);// int 自带有接口
            //return this.Name.CompareTo(other.Name);// string 自带有接口
        }
    }
    }
