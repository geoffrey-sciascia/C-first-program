using System;

namespace MyUtilities
{
    class WeatherUtilities
    {
        // Public to allow access to another file.
        public static float FahrenheitToCelsius(float temperatureFahrenheit)
        {
            return (temperatureFahrenheit - 32) / 1.8f;
        }

        public static float CelsiusToFahrenheit(float temperatureCelsius)
        {
            return temperatureCelsius * 1.8f + 32;
        }

        // The higher the number, the lower the comfort.
        // Private because it is not used in another file
        private static float ComfortIndex(float temperatureFahrenheit, float humidityPercent)
        {
            // Probably not a very reliable formula:
            return (temperatureFahrenheit + humidityPercent) / 4;
        }

        public static void Report(string location, float temperatureCelsius, float humidity)
        {
            var temperatureFahrenheit = CelsiusToFahrenheit(temperatureCelsius);
            // Interpolated string holding variables rather than concatenated string
            Console.WriteLine($"Comfort Index for {location}: {ComfortIndex(temperatureFahrenheit, humidity)}");
        }
    }
}