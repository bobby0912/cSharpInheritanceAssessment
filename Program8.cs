//8.Upcasting and Downcasting
//Time: 15 mins
//Create a base class `Person` and derive a class `Student`. Create an object of `Student`,
//upcast it to `Person`, and then downcast it back to `Student`. Demonstrate how type casting works.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpInheritanceAssessment
{
    class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }
    }

    class Student : Person
    {
        public string School { get; set; }
        public Student(string name, string school) : base(name)
        {
            School = school;
        }
    }
    class Program8
    {
        //static void Main(string[] args)
        //{
        //    Student student = new Student("John", "XYZ School");
        //    Person person = student;
        //    Student student1 = (Student)person;
        //    Console.WriteLine(student1.Name);
        //    Console.WriteLine(student1.School);
        //}
    }
}
