using System;

namespace MathOperationApp
{
    // This is a custom class named 'MathHandler'
    class MathHandler
    {
        // This method takes two integers as input
        // It multiplies the first number by 2 (example math operation)
        // Then displays the second number
        public void DoMathOperation(int number1, int number2)
        {
            // Perform a simple math operation: multiply number1 by 2
            int result = number1 * 2;

            // Display the result of the math operation
            Console.WriteLine("Result of math operation on number1: " + result);

            // Display the second number
            Console.WriteLine("Second number (number2): " + number2);
        }
    }

    // This is the Program class containing the Main method - the entry point of the console app
    class Program
    {
        // The Main method is where the application starts executing
        static void Main(string[] args)
        {
            // Create an instance of the MathHandler class
            MathHandler mathHandler = new MathHandler();

            // Call the DoMathOperation method using positional arguments
            // Here, number1 = 5, number2 = 10
            mathHandler.DoMathOperation(5, 10);

            // Call the DoMathOperation method using named arguments
            // This helps improve code readability
            mathHandler.DoMathOperation(number1: 8, number2: 3);

         
        }
    }
}
