﻿using System;
using System.Collections.Generic;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book System");
            Contact.GetCustomer();
            //Contact.Modify();
            Contact.ListingPeople();
            Contact.RemovePeople();            
            Console.ReadLine();
        }
    }
    
}
