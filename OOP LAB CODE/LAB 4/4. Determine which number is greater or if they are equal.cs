using System;

class Program
{
    public static void Main()
    {
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2)
            Console.WriteLine("First number is greater.");
        else if (num2 > num1)
            Console.WriteLine("Second number is greater.");
        else
            Console.WriteLine("Both numbers are equal.");
    }
}