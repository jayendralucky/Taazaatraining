using System.Collections;
using System.Collections.Generic;
using System;
namespace day6.Collections
{
    public class Candidates
    {
        public String AddCandidatesName()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Lucky");//Boxing
            arrayList.Add("Lucky Singh");
            string Name = (string)arrayList[1]; //Unboxing
            //Console.WriteLine(Name);
            return Name;
        }
         public void AddCandidatesNames()
        {
            List<string> obj = new List<string>();
            obj.Add("Lucky singh");
             obj.Add("Vicky singh");
          if (obj.Contains("Lucky Singh"))
          {
              Console.WriteLine("name found");
          }
          else
          {
              Console.WriteLine("not found");
          }
             

             

        }
        }
    }