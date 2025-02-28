//10.Prevent Inheritance Using Sealed Class
//Time: 10 mins
//Create a `sealed` class `SecuritySystem` with a method `AuthenticateUser()`. Try to derive a
//class from it and observe the compiler error. Explain why `sealed` is useful in real - world applications.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpInheritanceAssessment
{
    sealed class SecuritySystem
    {
        public void AuthenticateUser()
        {
            Console.WriteLine("User Authenticated");
        }
    }

    //class DerivedClass : SecuritySystem
    //{
    //}
    class Program10
    {
        static void Main(string[] args)
        {
            //DerivedClass derivedClass = new DerivedClass();
            //derivedClass.AuthenticateUser();
        }
    }
}
