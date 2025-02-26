using System;

class Program
{
    public static void Main(string[] args)
    {
        int[] arr = { 20, 35, 1, 70, 85 };
        int n = arr.Length;
        int[] even = new int[n];
        int[] odd = new int[n];
        int evenindex = 0;
        int oddIndex = 0;
        foreach (int value in arr)
        {
            if (value % 2 == 0)
            { even[evenindex] = value; evenindex++; }


            else
            {

                odd[oddIndex] = value;
                oddIndex++;
            }


        }
        Console.WriteLine("even Array =");
        for (int i = 0; i < even.Length; i++)
            Console.WriteLine(even[i]);
        Console.WriteLine("Odd Array =");
        for (int i = 0; i < odd.Length; i++)
            Console.WriteLine(odd[i]);
    }


    }
