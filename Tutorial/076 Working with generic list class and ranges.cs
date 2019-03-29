/*
AddRange()
GetRange()
InsertRange()
RemoveRange()
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
                Salary = 5000,
                Type="RetailCustomer"
            };
            Customer customer2 = new Customer()
            {
                ID = 102,
                Name = "honn",
                Salary = 5500,
                Type = "RetailCustomer"
            };
            Customer customer3 = new Customer()
            {
                ID = 103,
                Name = "john",
                Salary = 3400,
                Type = "CorporateCustomer"
            };
            Customer customer4 = new Customer()
            {
                ID = 104,
                Name = "johen",
                Salary = 3430,
                Type = "CorporateCustomer"
            };



            List<Customer> listCustomers = new List<Customer>();
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);

            List<Customer> listCorporateCustomers = new List<Customer>();
            listCustomers.Add(customer3);
            listCustomers.Add(customer4);

            listCustomers.AddRange(listCorporateCustomers);//(1,2,3,4)

            List<Customer> customers=listCustomers.GetRange(2, 2);//2,3

            listCustomers.InsertRange(0, listCorporateCustomers);//(3,4,1,2,3,4)

            listCustomers.RemoveRange(1, 2);//(3,2,3,4)

            listCustomers.RemoveAll(x => x.Type == "CorporateCustomer");//(2)
        }
    }
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Type { get; set; }
    }
}
