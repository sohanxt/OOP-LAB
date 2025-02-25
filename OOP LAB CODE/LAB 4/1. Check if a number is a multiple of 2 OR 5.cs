using System;

class Program
{
    public static void Main()
    {
        Console.Write("Enter an integer: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0 || number % 5 == 0)
        {
            Console.WriteLine(number);
        }
        else
        {
            Console.WriteLine("Not a multiple of 2 OR 5");
        }
    }
}