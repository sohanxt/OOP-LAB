using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number for factorial: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }

        Console.WriteLine($"Factorial of {n} is: {factorial}");
    }
}
