using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAssignment
{
    //ABSTRACT AND POLYMORPHISM ASSIGNMENT
    abstract class Person
    {
        public string fName { get; set; }
        public string lName { get; set; }

        //abstract method
        public abstract void SayName();
    }

    //employee inheriting from person
    class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine($"Name: {fName} {lName}");
            Console.ReadLine();
        }

        public void Quit()
        {
            Console.WriteLine($"{fName} {lName} has quit the job.");
        }
    }

    interface IQuittable
    {
        void Quit();
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee()
            {
                fName = "Sample",
                lName = "Student"
            };

            employee.SayName();

            IQuittable quittable = employee;
            quittable.Quit();

            Console.ReadLine();
        }
    }
}
