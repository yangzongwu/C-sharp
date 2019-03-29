using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 8, 3, 5, 6, 2 };
            foreach(int num in numbers)
            {
                Console.Write("{0},",num); //1,8,3,5,6,2,
            }
            Console.WriteLine();

            numbers.Sort();
            foreach (int num in numbers)
            {
                Console.Write("{0},", num); //1,2,3,5,6,8,
            }
            Console.WriteLine();

            numbers.Reverse();
            foreach (int num in numbers)
            {
                Console.Write("{0},", num); //8,6,5,3,2,1,
            }
            Console.WriteLine();



            List<string> alphabets = new List<string> { "a", "d", "g", "c" };
            foreach (string num in alphabets)
            {
                Console.Write("{0},", num); //a,d,g,c,
            }
            Console.WriteLine();

            alphabets.Sort();
            foreach (string num in alphabets)
            {
                Console.Write("{0},", num); //a,c,d,g,
            }
            Console.WriteLine();

            alphabets.Reverse();
            foreach (string num in alphabets)
            {
                Console.Write("{0},", num); //g,d,c,a,
            }
            Console.WriteLine();

        }
    }
}
//================================================================================
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

            listCustomers.Sort();//???
        }
    }
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
