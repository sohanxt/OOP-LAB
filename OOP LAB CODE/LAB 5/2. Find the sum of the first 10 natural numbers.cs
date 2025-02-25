using System;

class Program
{
    public static void Main(string[] args)
    {
        int sum = 0;
        for (int i = 1; i <= 10; i++)
        {
            sum += i;
        }
        Console.WriteLine("Sum of the first 10 natural numbers: " + sum);
    }
}
