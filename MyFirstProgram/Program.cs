using System;
// Gets all methods from MyUtilities namespace.
using MyUtilities;

namespace MyFirstProgram
{
    // Class to hold the main method for this program.
    class CheckComfort
    {
        // Method to hold the location arguments used by the methods from MyUtilities.
        // Is void because it returns nothing.
        static void Main(string[] args)
        {
            Console.WriteLine("Where should we go next May?");
            WeatherUtilities.Report("San Francisco", WeatherUtilities.FahrenheitToCelsius(65), 73);
            WeatherUtilities.Report("Melbourne", WeatherUtilities.FahrenheitToCelsius(64), 47);
            // Lower case f after temp to tell the compiler that the number should be treated as a floating point rather than a double.
            WeatherUtilities.Report("Wellington", 13.7f, 76); // ~64 F (hell yeah! that was a guess!)
            WeatherUtilities.Report("London", 17.5f, 75);
            WeatherUtilities.Report("Tokyo", WeatherUtilities.FahrenheitToCelsius(71), 69);
            WeatherUtilities.Report("New York", WeatherUtilities.FahrenheitToCelsius(71), 79);
        }
    }
}
