using System;
using day7.Delegate;
delegate int customDelegate();
namespace day7
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj1 = new Person();
            customDelegate cobj = new customDelegate(obj1.PhoneNo);
            var temp = cobj.Invoke();
            Console.WriteLine(temp);
            
            cobj-=obj1.walk; // multicasr(+=)
            var temp1 = cobj.Invoke();
            Console.WriteLine(temp1);

            

        }
    }
}
