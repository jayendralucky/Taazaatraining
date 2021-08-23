using System;

namespace actiondelegatet
{
    class Program
    {
        public delegate void Print(int val);
        static void ConsolePrint(int i)
        {
            Console.WriteLine(i);
        }
        static void Main(string[] args)
        {
            Print print = ConsolePrint;
            print(10);
            
        }
    }
}
