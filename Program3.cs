//3.Constructor Chaining in Inheritance
//Time: 15 mins
//Create a class `Employee` with properties `Name` and `Salary`. Derive a class `Manager`
//that has an additional property `Bonus`. Use constructor chaining to initialize the properties from the base class.




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpInheritanceAssessment
{
    class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }
    }

    class Manager : Employee
    {
        public double Bonus { get; set; }
        public Manager(string name, double salary, double bonus) : base(name, salary)
        {
            Bonus = bonus;
        }
    }
    class Program3
    {
        //static void Main(string[] args)
        //{
        //    Manager manager = new Manager("John", 50000, 5000);
        //    Console.WriteLine("Name: " + manager.Name);
        //    Console.WriteLine("Salary: " + manager.Salary);
        //    Console.WriteLine("Bonus: " + manager.Bonus);
        //}
    }
}
