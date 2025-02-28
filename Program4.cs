//4.Abstract Class and Polymorphism
//Time: 15 mins
//Create an abstract class `Animal` with an abstract method `MakeSound()`. Derive two classes `Dog`
//and `Cat` that override `MakeSound()`. Instantiate objects of both classes and call the method.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpInheritanceAssessment
{
    abstract class Animal
    {
        public abstract void MakeSound();
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat meows");
        }
    }
    class Program4
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.MakeSound();
            Cat cat = new Cat();
            cat.MakeSound();
        }
    }
}
