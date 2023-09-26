using System;

class Program
{
    static void Main()
    {
        Temperature temperature = new Temperature(25.0); 
        Console.WriteLine($"Temperature in Celsius: {temperature.Celsius}°C");
        Console.WriteLine($"Temperature in Fahrenheit: {temperature.Fahrenheit}°F");

        
        temperature.Celsius = 32.0;
        Console.WriteLine($"Updated temperature in Celsius: {temperature.Celsius}°C");
        Console.WriteLine($"Updated temperature in Fahrenheit: {temperature.Fahrenheit}°F");
    }
}
