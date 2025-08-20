using System;

namespace EmployeeComparisonApp
{
    // Define the Employee class with Id, FirstName, and LastName properties
    public class Employee
    {
        // Auto-implemented properties for storing employee information
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overload the == operator to compare two Employee objects by Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // If both are null, they're equal
            if (ReferenceEquals(emp1, null) && ReferenceEquals(emp2, null))
                return true;

            // If only one is null, they're not equal
            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
                return false;

            // Compare the Ids of the two employees
            return emp1.Id == emp2.Id;
        }

        // Overload the != operator (must always pair with ==)
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            // Return the opposite of the == operator result
            return !(emp1 == emp2);
        }

        // Override Equals to match the logic of the == operator
        public override bool Equals(object obj)
        {
            // Cast the object to Employee and compare Ids
            Employee other = obj as Employee;
            if (other == null)
                return false;

            return this.Id == other.Id;
        }

        // Override GetHashCode to be consistent with Equals
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }

    // Main program class
    class Program
    {
        // Main method - application entry point
        static void Main(string[] args)
        {
            // Create first employee with specific Id and name
            Employee employee1 = new Employee
            {
                Id = 101,
                FirstName = "Nadine",
                LastName = "Khaddam"
            };

            // Create second employee with different Id
            Employee employee2 = new Employee
            {
                Id = 102, 
                FirstName = "Employee",
                LastName = "two"
            };

            // Compare the two employees using the overloaded == operator
            bool areEqual = employee1 == employee2;

            // Output the result of the comparison
            Console.WriteLine("Are employee1 and employee2 equal? " + areEqual);

            // Also test the != operator
            bool areNotEqual = employee1 != employee2;
            Console.WriteLine("Are employee1 and employee2 NOT equal? " + areNotEqual);

        }
    }
}
