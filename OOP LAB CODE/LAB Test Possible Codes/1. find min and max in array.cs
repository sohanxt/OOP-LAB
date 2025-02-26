using System;

class Program
{
    public static void Main(string[] args)
    {
        int[] arr = { 20, 35, 1, 70, 85 };
        int max = arr[0];
        int min = arr[0];
        foreach (int value in arr)
        {
            if (value > max)
                max = value;
            
            if (value < min)
                min = value;
                   
        }
        Console.WriteLine($"max value = {max} \n min value = {min} ");
    }
}
