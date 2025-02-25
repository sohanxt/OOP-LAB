using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int isPrime = 1; // Assume the number is prime initially

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                isPrime = 0; // Not prime
                break;
            }
        }

        if (n > 1 && isPrime == 1)
            Console.WriteLine($"{n} is prime.");
        else
            Console.WriteLine($"{n} is not prime.");
    }
}
