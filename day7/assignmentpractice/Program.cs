using System;
using assignmentpractice.Models;
using System.Collections.Generic;

namespace assignmentpractice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contact>list =new List<Contact>();
            list.Add(new Contact{
                Contactid=101,
                Contactname="jayendra",
                ContactPhone=978979526
            });
            list.Add(new Contact{
                Contactid=102,
                Contactname="jayendra singh",
                ContactPhone=975653232
            });
            
            //updating
            int target =1;
            list[target].Contactname="lucky";
            list[target].Contactid=105;
            Console.WriteLine("update"+list[target].Contactid+" "+list[target].Contactname+" "+list[target].ContactPhone);
            //removing from the list 
            int tar =1;
            list.RemoveAt(1);
            //searching
            int result = list.Find(x =>x.Contactname==);

            

             var count =list.Count;
            for(int i=0;i<count;i++)
            {
                Console.WriteLine(list[i].Contactname+" "+list[i].Contactid+" "+list[i].ContactPhone);
            } 
            
            
        }
    }
}
