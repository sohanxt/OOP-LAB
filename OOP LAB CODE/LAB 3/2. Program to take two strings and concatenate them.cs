using System;

class Program
{
    public static void Main()
    {
        Console.Write("Enter first string: ");
        string first = Console.ReadLine();

        Console.Write("Enter second string: ");
        string second = Console.ReadLine();

        string constring = first + " " + second;
        Console.WriteLine("Concatenated String: " + constring);
    }
}
