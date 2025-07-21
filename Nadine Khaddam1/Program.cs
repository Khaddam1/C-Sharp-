using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display a welcome message to the user
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt the user to enter the package weight
            Console.WriteLine("Please enter the package weight:");
            // Read and convert the weight input to a double
            double weight = Convert.ToDouble(Console.ReadLine());

            // Check if the package is too heavy
            if (weight > 50)
            {
                // Inform the user and exit if the package is too heavy
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return;
            }

            // Prompt the user to enter the package width
            Console.WriteLine("Please enter the package width:");
            // Read and convert the width input to a double
            double width = Convert.ToDouble(Console.ReadLine());

            // Prompt the user to enter the package height
            Console.WriteLine("Please enter the package height:");
            // Read and convert the height input to a double
            double height = Convert.ToDouble(Console.ReadLine());

            // Prompt the user to enter the package length
            Console.WriteLine("Please enter the package length:");
            // Read and convert the length input to a double
            double length = Convert.ToDouble(Console.ReadLine());

            // Calculate the sum of the dimensions
            double dimensionTotal = width + height + length;

            // Check if the package dimensions exceed the limit
            if (dimensionTotal > 50)
            {
                // Inform the user and exit if the package is too large
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return;
            }

            // Calculate the volume of the package
            double volume = width * height * length;

            // Calculate the quote by multiplying the volume by the weight and dividing by 100
            double quote = (volume * weight) / 100;

            // Display the shipping quote as a formatted dollar amount
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
            Console.WriteLine("Thank you!");
        }
    }
}
