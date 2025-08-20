using System;

namespace InterfacePolymorphismApp
{
    // Define an interface called IQuittable
    // Interfaces define a contract that implementing classes must follow
    interface IQuittable
    {
        // Declare a method signature named Quit with no return type (void)
        void Quit();
    }

    // Define a class named Employee that implements the IQuittable interface
    class Employee : IQuittable
    {
        // Optional: Adding FirstName and LastName properties for extra context
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Constructor to set the first and last name
        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        // Implement the Quit method defined in the IQuittable interface
        public void Quit()
        {
            // Simple implementation that writes to the console
            Console.WriteLine($"{FirstName} {LastName} has quit the job.");
        }
    }

    // Main class where program execution begins
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of Employee
            Employee employee = new Employee("Naddine", "Khaddam");

            // Use polymorphism: assign an Employee object to an IQuittable interface reference
            IQuittable quittableEmployee = employee;

            // Call the Quit method using the interface type reference
            // This is possible because Employee implements IQuittable
            quittableEmployee.Quit();
        }
    }
}
