//1.Implement a Basic Inheritance Hierarchy
//Time: 10 mins
//Create a base class `Vehicle` with properties `Brand` and `Speed`. Derive two classes `Car`
//and `Bike` from `Vehicle`. Add a method `DisplayInfo()` in `Vehicle` that should be accessible
//in the derived classes.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpInheritanceAssessment
{
    class Vehicle
    {
        public string Brand { get; set; }
        public int Speed { get; set; }
        public void DisplayInfo()
        {
            Console.WriteLine("Brand: " + Brand + " Speed: " + Speed);
        }
    }

    class Car : Vehicle
    {
        public Car(string brand, int speed)
        {
            Brand = brand;
            Speed = speed;
        }
    }

    class Bike : Vehicle
    {
        public Bike(string brand, int speed)
        {
            Brand = brand;
            Speed = speed;
        }
    }

    internal class Program1
    {
        //static void Main(string[] args)
        //{
        //    Car car = new Car("Toyota", 100);
        //    Bike bike = new Bike("Honda", 50);
        //    car.DisplayInfo();
        //    bike.DisplayInfo();
        //}
    }
}
