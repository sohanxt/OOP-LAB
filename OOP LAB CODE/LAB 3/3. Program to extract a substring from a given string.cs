using System;

class Program
{
    public static void Main()
    {
        Console.Write("Enter the original string: ");
        string inputString = Console.ReadLine();

        Console.Write("Enter the starting index: ");
        int startIndex = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the length of substring: ");
        int length = Convert.ToInt32(Console.ReadLine());

        if (startIndex >= 0 && startIndex + length <= inputString.Length)
        {
            string substring = inputString.Substring(startIndex, length);
            Console.WriteLine("Extracted Substring: " + substring);
        }
        else
        {
            Console.WriteLine("Invalid index or length!");
        }
    }
}
