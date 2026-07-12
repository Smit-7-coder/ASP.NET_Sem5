using System; // Imports the System namespace for Console and Convert classes
using System.Collections.Generic; // Imports classes for generic collections
using System.Linq; // Imports LINQ functionality
using System.Text; // Imports classes for text handling
using System.Threading.Tasks; // Imports classes for asynchronous programming

namespace ASP.NET // Defines a namespace named ASP.NET
{
    internal class Factorial // Defines an internal class named Factorial
    {
        public static void fact() // Defines a public static method named fact
        {
            int number; // Declares an integer variable named number

            Console.Write("Enter Number For Factorial: "); // Displays a message to enter a number

            String str = Console.ReadLine(); // Reads input from the user and stores it as a string

            number = Convert.ToInt32(str); // Converts the string input into an integer

            int fact = 1; // Declares and initializes factorial variable with 1

            for (int i = 1; i <= number; i++) // Loops from 1 up to the entered number
            {
                fact *= i; // Multiplies fact by the current value of i
            }

            Console.WriteLine($"the factorial of {number} is {fact}"); // Displays the factorial result
        }
    }
}