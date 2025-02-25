using System;

class Program
{
    public static void Main(string[] args)
    {
        for (int i = 10; i <= 150; i++)
        {
            if (i % 5 == 0 && i % 7 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
