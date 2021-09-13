using System;
using System.Collections.Generic;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book System");
            ReadInput.PersonDetails();
            Console.ReadLine();
        }
    }
    class ReadInput
    {
        public static void PersonDetails()
        {
            Console.Write("Enter First Name: ");
            String firstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter Address : ");
            var Addresses = Console.ReadLine();

            Console.Write("Enter City : ");
            string city = Console.ReadLine();

            Console.Write("Enter State : ");
            string state = Console.ReadLine();

            Console.Write("Enter ZipCode: ");
            string zipCode = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            string phoneNumber = Console.ReadLine();

            Console.Write("Enter EmailId: ");
            string Email = Console.ReadLine();
            //Adding fetched details to list
            List<string> PersonList = new List<string>();
            PersonList.Add(firstName);
            PersonList.Add(lastName);
            PersonList.Add(city);
            PersonList.Add(state);
            PersonList.Add(zipCode);
            PersonList.Add(Email);
            foreach (string i in PersonList)
            {
                Console.WriteLine(i);
            }
        }
    }
}
