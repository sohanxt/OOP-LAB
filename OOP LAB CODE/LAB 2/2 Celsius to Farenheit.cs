using System;

class Program
{
    public static void Main()
    {
        Console.Write("Enter temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        double fahrenheit = (9.0 / 5.0) * celsius + 32;
        Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);
    }
}