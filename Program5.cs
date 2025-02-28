//5.Interface vs Inheritance in C#
//Time: 15 mins
//Create an interface `IMovable` with a method `Move()`. Implement this interface in a `Robot` class.
//Also, create a base class `Machine` with a method `Start()`. Have `Robot` inherit from `Machine` and implement `IMovable`.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpInheritanceAssessment
{
    interface IMovable
    {
        void Move();
    }

    class Machine
    {
        public void Start()
        {
            Console.WriteLine("Machine started");
        }
    }

    class Robot : Machine, IMovable
    {
        public void Move()
        {
            Console.WriteLine("Robot moving");
        }
    }
    class Program5
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot();
            robot.Start();
            robot.Move();
        }
    }
}
