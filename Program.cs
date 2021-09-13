using System;
using System.Collections.Generic;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book System!");
            Console.WriteLine("1.Enter to add the details");
            Console.WriteLine("2.Enter to modify the details");
            Console.WriteLine("3.Listing the details..");
            Console.WriteLine("4.Remove the details");
            Console.WriteLine("Enter a option");
            switch (Console.ReadLine())
            {
                case "1":
                    Contact.GetCustomer();
                    Contact.ListingPeople();
                    break;
                case "2":
                    Contact.GetCustomer();
                    Contact.Modify();
                    Contact.ListingPeople();
                    break;
                case "3":
                    Contact.GetCustomer();
                    Contact.ListingPeople();
                    break;
                case "4":
                    Contact.GetCustomer();
                    Contact.RemovePeople();

                    break;
                default:
                    Console.WriteLine("Enter a valid option");
                    break;

            }



        }
    }
}
    

