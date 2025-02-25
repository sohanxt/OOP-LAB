using System;

class Program
{
    public static void Main(string[] args)
    {
        int sum = 0;
        int[] numbers = new int[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
            sum += numbers[i];
        }

        double average = sum / 10.0;
        Console.WriteLine($"Sum: {sum}, Average: {average}");
    }
}
