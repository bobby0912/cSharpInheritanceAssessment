//9.Real - World Scenario: E - Commerce System
//Time: 20 mins
//Create a base class `Product` with properties `Name` and `Price`. Derive two classes
//`ElectronicProduct` and `ClothingProduct`. Add a `GetDiscountedPrice()` method in the base
//class and override it in the derived classes to apply different discount rules.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpInheritanceAssessment
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public virtual double GetDiscountedPrice()
        {
            return Price;
        }
    }

    class ElectronicProduct : Product
    {
        public ElectronicProduct(string name, double price) : base(name, price)
        {
        }
        public override double GetDiscountedPrice()
        {
            return Price * 0.9;
        }
    }

    class ClothingProduct : Product
    {
        public ClothingProduct(string name, double price) : base(name, price)
        {
        }
        public override double GetDiscountedPrice()
        {
            return Price * 0.8;
        }
    }
    class Program9
    {
        static void Main(string[] args)
        {
            Product p1 = new ElectronicProduct("Laptop", 50000);
            Product p2 = new ClothingProduct("Shirt", 1000);
            Console.WriteLine("Product Name: {0}, Price: {1}, Discounted Price: {2}", p1.Name, p1.Price, p1.GetDiscountedPrice());
            Console.WriteLine("Product Name: {0}, Price: {1}, Discounted Price: {2}", p2.Name, p2.Price, p2.GetDiscountedPrice());
        }
    }
}
