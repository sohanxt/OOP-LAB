using System;

class Program
{
    public static void Main()
    {
        Console.Write("Enter the base of the triangle: ");
        double baselenght = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the height of the triangle: ");
        double height = Convert.ToDouble(Console.ReadLine());

        double area = (baselenght * height) / 2;
        Console.WriteLine("Area of the triangle: " + area);
    }
}
