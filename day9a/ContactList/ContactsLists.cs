using System.Collections.Generic;
using day9a.Models;
namespace day9a.ContactList
{
    public class ContactsLists
    {
        List<Contact> objList;
        public ContactsLists()
        {
            objList=new List<Contact>();
        }
        public void  createContact(Contact objContact)
        {
            objList.Add(objContact);
        }
        public List<Contact> DisplayList()
        {
            return objList;
        }
    }
}