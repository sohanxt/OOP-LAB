using System;

class Program
{
    public static void Main(string[] args)
    {
        int n = 4; // Input number
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
