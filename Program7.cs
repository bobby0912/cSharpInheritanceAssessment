//7.Multiple Inheritance Using Interfaces
//Time: 15 mins
//Create two interfaces `IFlyable` and `ISwimmable` with methods `Fly()` and `Swim()`,
//respectively. Implement these interfaces in a class `Duck` to exhibit both behaviors.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpInheritanceAssessment
{
    interface IFlyable
    {
        void Fly();
    }

    interface ISwimmable
    {
        void Swim();
    }

    class Duck : IFlyable, ISwimmable
    {
        public void Fly()
        {
            Console.WriteLine("Duck flying");
        }
        public void Swim()
        {
            Console.WriteLine("Duck swimming");
        }
    }
    class Program7
    {
        static void Main(string[] args)
        {
            Duck duck = new Duck();
            duck.Fly();
            duck.Swim();
        }
    }
}
