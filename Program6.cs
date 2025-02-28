//6.Sealed Class and Methods
//Time: 12 mins
//Create a base class `Account` with a virtual method `CalculateInterest()`. Derive a class
//`SavingsAccount` and override `CalculateInterest()`. Now, prevent further overriding by marking it as `sealed`.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpInheritanceAssessment
{
    class Account
    {
        public virtual void CalculateInterest()
        {
            Console.WriteLine("Interest calculated");
        }
    }

    class SavingsAccount : Account
    {
        public sealed override void CalculateInterest()
        {
            Console.WriteLine("Interest calculated for Savings Account");
        }
    }

    class Program6
    {
        static void Main(string[] args)
        {
            SavingsAccount sa = new SavingsAccount();
            sa.CalculateInterest();
        }
    }
}
