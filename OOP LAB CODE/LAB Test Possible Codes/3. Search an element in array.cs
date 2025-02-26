using System;

class Program
{
    public static void Main(string[] args)
    {
        int[] arr = { 20, 35, 1, 70, 85 };
        Console.WriteLine("Enter the element you want to search");
        int element = Convert.ToInt32(Console.ReadLine());
        int position = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == element)
                position = i + 1;
        }

        if (position == 0)
            Console.WriteLine("Element is not found in array");
        else
            Console.WriteLine($"Position of {element} in array is {position}");




    }
}