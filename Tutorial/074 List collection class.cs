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

            //Customer[] customers = new Customer[2];
            //customers[0] = customer1;
            //customers[1] = customer2;
            //customers[2] = customer3;//error

            List<Customer> customers = new List<Customer>();//strong typed
            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);
            SavingCustomer sc = new SavingCustomer();
            customers.Add(sc);//ok inheritance


            customers.Insert(0, customer3);

            Console.WriteLine(customers.IndexOf(customer3));//0
            Console.WriteLine(customers.IndexOf(customer3,1));//3 //start from 1,
            Console.WriteLine(customers.IndexOf(customer3, 1,2));//-1//start from 1,search 2 obj
            Console.WriteLine(customers.IndexOf(customer3, 1, 212));//error

            Customer C = customers[0];
            Console.WriteLine(C.Name);

            foreach(Customer Cc in customers)
            {
                Console.WriteLine(Cc.Name);
            }

            for (int i=0;i<customers.Count;i++)
            {
                Customer c = customers[i];
                Console.WriteLine(c.Name);
            }


        }
    }
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
    public class SavingCustomer : Customer { }
}
