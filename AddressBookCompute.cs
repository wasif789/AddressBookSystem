﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class AddressBookCompute
    {
        private List<ContactDetails> contactList;
        bool AVAILABLE = false;
        //creates the object linked list 
        public AddressBookCompute()
        {
            this.contactList = new List<ContactDetails>();
        }

        //this method add details to the address book
        public void AddContactDetails(string firstName, string lastName, string address, string city, string state, long zipCode, long phoneNumber)
        {
            //find the data that already has the same value 
            ContactDetails details = this.contactList.Find(x => x.firstName.Equals(firstName));
            //if no sush record is available then add the data
            if (details == null)
            {
                ContactDetails contactDetails = new ContactDetails(firstName, lastName, address, city, state, zipCode, phoneNumber);
                this.contactList.Add(contactDetails);
            }
            //else print record is already available
            else
            {
                Console.WriteLine("record with same name as {0} is available in the address book", firstName);
            }
        }

        //calls the display method
        public void DisplayContact()
        {
            foreach (ContactDetails contact in this.contactList)
            {
                contact.Display();
            }
        }
        //Delete the particular object
        public void DeleteContact(string name)
        {
            AVAILABLE = false;
            foreach (ContactDetails contact in this.contactList)
            {
                if (contact.firstName.Equals(name))
                {
                    this.contactList.Remove(contact);
                    AVAILABLE = true;
                    break;
                }
            }
            if (!AVAILABLE)
            {
                Console.WriteLine("{0} record not available in the address book", name);
            }
        }

        public void EditContact(string name, long number)
        {
            AVAILABLE = false;
            //checks for every object whether the name is equal the given name
            foreach (ContactDetails contact in this.contactList)
            {
                if (contact.firstName.Equals(name))
                {
                    //calls the setdetail method
                    contact.SetDetail(number);
                    AVAILABLE = true;
                    break;
                }
            }
            if (!AVAILABLE)
            {
                Console.WriteLine("{0} record not available in the address book", name);
            }

        }

        public static void DisplayPerson(Dictionary<string, AddressBookCompute> addressDictionary)
        {
            List<ContactDetails> list = null;
            //List<ContactDetails> stateList = new List<ContactDetails>();
            string SCName;
            Console.WriteLine("Enter City or State name:");
            SCName = Console.ReadLine();
            foreach (var l in addressDictionary)
            {
                AddressBookCompute address = l.Value;
                list = address.contactList.FindAll(x => x.city.Equals(SCName) || x.state.Equals(SCName));
                if (list.Count > 0)
                {
                    DisplayList(list);
                }
            }

        }
        public static void DisplayList(List<ContactDetails> l)
        {
            foreach (var data in l)
            {
                data.Display();
            }
        }


    }
}