using System;

class Program
{
    public static void Main(string[] args)
    {
        int[] arr = { 20, 35, 1, 70, 85 };
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int maxIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] > arr[maxIndex])  // Change condition to find maximum
                    maxIndex = j;
            }
            
            int temp = arr[maxIndex];
            arr[maxIndex] = arr[i];
            arr[i] = temp;
        }

        foreach (int num in arr)
            Console.WriteLine(num);
    }
}
