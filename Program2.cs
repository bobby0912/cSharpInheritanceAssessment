//2.Method Overriding and Base Keyword
//Time: 12 mins
//Modify the `DisplayInfo()` method in `Vehicle` to print `Brand` and `Speed`. Override
//this method in `Car` and `Bike` to include additional specific information. Ensure
//the base class method is called using `base.DisplayInfo()`.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpInheritanceAssessment
{
    class Vehicle1
    {
        public string Brand { get; set; }
        public int Speed { get; set; }
        public Vehicle1(string brand, int speed)
        {
            Brand = brand;
            Speed = speed;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Brand: {0}, Speed: {1}", Brand, Speed);
        }
    }

    class Car1 : Vehicle1
    {
        public Car1(string brand, int speed) : base(brand, speed)
        {
        }
        public new void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("This is a Car");
        }
    }

    class Bike1 : Vehicle1
    {
        public Bike1(string brand, int speed) : base(brand, speed)
        {
        }
        public new void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("This is a Bike");
        }
    }
    class Program2
    {
        //static void Main(string[] args)
        //{
        //    Car1 car = new Car1("Toyota", 100);
        //    Bike1 bike = new Bike1("Honda", 50);
        //    car.DisplayInfo();
        //    bike.DisplayInfo();
        //    Console.ReadLine();
        //}

    }
}
