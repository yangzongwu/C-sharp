/*
Contains()
Exists()
Find()
FindLast()
FindAll()
FindIndex()
FindLastIndex()
ToList()  array--list
ToArray()  list--array
ToDictionary()  list--dictionary
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

            //Customer[] customers = new Customer[2];
            //customers[0] = customer1;
            //customers[1] = customer2;
            //customers[2] = customer3;//error

            List<Customer> listCustomers = new List<Customer>();//strong typed
            listCustomers.Add(customer3);
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);


            if (listCustomers.Contains(customer3))
            {
                Console.WriteLine("customer3 contains");
            }
            else
            {
                Console.WriteLine("customer3 not contains");
            }


            if (listCustomers.Exists(cust=>cust.Name.StartsWith("j")))
            {
                Console.WriteLine(" contains");
            }
            else
            {
                Console.WriteLine("not contains");
            }

            Customer c = listCustomers.Find(cust => cust.Salary > 5000);  //return the first item
            Console.WriteLine(c.Name);

            Customer cLast = listCustomers.FindLast(cust => cust.Salary > 5000);  //return the Last item
            Console.WriteLine(cLast.Name);

            List<Customer> customers = listCustomers.FindAll(cust => cust.Salary > 1000);  //return all item
            foreach(Customer cus in customers)
            {
                Console.WriteLine(cus.Name);
            }

            int index = listCustomers.FindIndex(cust => cust.Salary > 1000);
            Console.WriteLine(index);//0

            int index1 = listCustomers.FindIndex(2,cust => cust.Salary > 1000);
            Console.WriteLine(index1);//2

            int index2 = listCustomers.FindIndex(2, 2,cust => cust.Salary > 1000);
            Console.WriteLine(index2);//2

            int lastIndex = listCustomers.FindLastIndex(cust => cust.Salary > 1000);
            Console.WriteLine(lastIndex);//3


            Customer[] customerArray = new Customer[3];
            customerArray[0] = customer1;
            customerArray[1] = customer2;
            customerArray[2] = customer3;
            List<Customer> ListCustomers = customerArray.ToList();
            Customer[]  newArray=ListCustomers.ToArray();
            Dictionary<int, Customer> dictionary = ListCustomers.ToDictionary(x => x.ID);
        }
    }
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
