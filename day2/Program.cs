using System;

class Taazaa
{
    // intializing by obj variable 
readonly static string cpolicy;
    
    static Taazaa()//static constructor 
    {
        cpolicy="2 leaves in a month ";
        Console.WriteLine(cpolicy);

    }
    
    public static void Main()
    {
        Console.WriteLine("i am inside");
        
    }
}