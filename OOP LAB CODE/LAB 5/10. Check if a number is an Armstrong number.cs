using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number to check if it's Armstrong: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        int originalNumber = n;
        int numDigits = n.ToString().Length;

        while (n > 0)
        {
            int digit = n % 10;
            sum += (int)Math.Pow(digit, numDigits);
            n /= 10;
        }

        if (sum == originalNumber)
        {
            Console.WriteLine($"{originalNumber} is an Armstrong number.");
        }
        else
        {
            Console.WriteLine($"{originalNumber} is not an Armstrong number.");
        }
    }
}
