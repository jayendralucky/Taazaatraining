using System;
using day6.Collections;


namespace day6
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Candidates();
            var S = c.AddCandidatesName();
            Console.WriteLine(S);
            c.AddCandidatesNames();
        }
       
    }
}
