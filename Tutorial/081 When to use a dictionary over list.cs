//========================================================================================
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
            Country country1 = new Country() { Code = "AUS", Name = "Australia", Capital = "Canberra" };
            Country country2 = new Country() { Code = "IND", Name = "Inida", Capital = "New Delhi" };
            Country country3 = new Country() { Code = "USA", Name = "United State", Capital = "Wanshing D.C" };
            Country country4 = new Country() { Code = "GBR", Name = "United Kingdom", Capital = "London" };

            List<Country> listCountries = new List<Country>();
            listCountries.Add(country1);
            listCountries.Add(country2);
            listCountries.Add(country3);
            listCountries.Add(country4);

            string strUserChoice = string.Empty;
            do
            {
                Console.WriteLine("please enter Country code");
                string strCountryCode = Console.ReadLine().ToUpper();

                //find, look each object, too many item the time is bad
                Country reslutCountry = listCountries.Find(country => country.Code == strCountryCode);
                if (reslutCountry == null)
                {
                    Console.WriteLine("Country code not valie");
                }
                else
                {
                    Console.WriteLine("Name={0},Capital={1}", reslutCountry.Name, reslutCountry.Capital);
                }
                do
                {
                    Console.WriteLine("Do you want to continue-YES or NO");
                    strUserChoice = Console.ReadLine().ToUpper();
                }
                while (strUserChoice != "NO" && strUserChoice != "YES");
            }
            while (strUserChoice == "YES");
            
        }
    }
    public class Country
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Capital { get; set; }
    }
 }
 
 //========================================================================================
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
            Country country1 = new Country() { Code = "AUS", Name = "Australia", Capital = "Canberra" };
            Country country2 = new Country() { Code = "IND", Name = "Inida", Capital = "New Delhi" };
            Country country3 = new Country() { Code = "USA", Name = "United State", Capital = "Wanshing D.C" };
            Country country4 = new Country() { Code = "GBR", Name = "United Kingdom", Capital = "London" };

            Dictionary<string,Country> dictionaryCountries = new Dictionary<string,Country>();
            dictionaryCountries.Add(country1.Code, country1);
            dictionaryCountries.Add(country2.Code, country2);
            dictionaryCountries.Add(country3.Code, country3);
            dictionaryCountries.Add(country4.Code, country4);

            string strUserChoice = string.Empty;
            do
            {
                Console.WriteLine("please enter Country code");
                string strCountryCode = Console.ReadLine().ToUpper();

                //find, look each object, too many item the time is bad
                Country reslutCountry = dictionaryCountries.ContainsKey(strCountryCode)? dictionaryCountries[strCountryCode]:null;
                if (reslutCountry == null)
                {
                    Console.WriteLine("Country code not valie");
                }
                else
                {
                    Console.WriteLine("Name={0},Capital={1}", reslutCountry.Name, reslutCountry.Capital);
                }
                do
                {
                    Console.WriteLine("Do you want to continue-YES or NO");
                    strUserChoice = Console.ReadLine().ToUpper();
                }
                while (strUserChoice != "NO" && strUserChoice != "YES");
            }
            while (strUserChoice == "YES");
            
        }
    }
    public class Country
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Capital { get; set; }
    }
 }
