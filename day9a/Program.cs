using System;
using day9a.Models;
using day9a.ContactList;
using System.Collections.Generic;

namespace day9a
{
    class Program
    {
        static void Main()
        {
            Contact obj = new Contact();
            obj.ContactId=101;
            obj.ContactName="Sachin";

            Contact obj1 = new Contact();
             obj1.ContactId=102;
            obj1.ContactName="Sachin Kumar ";

            ContactsLists objContactsLists = new ContactsLists();
            objContactsLists.createContact(obj);
            objContactsLists.createContact(obj1);

            List<Contact> Contactobj  = objContactsLists.DisplayList();
            foreach(var item in Contactobj)
            {
                Console.WriteLine(item.ContactId+" "+item.ContactName);

            }
        }
    }
}
