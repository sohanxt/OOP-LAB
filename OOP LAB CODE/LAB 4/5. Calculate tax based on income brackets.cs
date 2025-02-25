using System;

class Program
{
    public static void Main()
    {
        Console.Write("Enter income: ");
        double income = Convert.ToDouble(Console.ReadLine());
        double taxRate;

        if (income <= 10000)
            taxRate = 0.05;
        else if (income <= 20000)
            taxRate = 0.10;
        else if (income <= 50000)
            taxRate = 0.15;
        else
            taxRate = 0.20;

        double tax = income * taxRate;
        Console.WriteLine("Tax Amount: $" + tax);
    }
}