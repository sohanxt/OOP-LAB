using System;

class Program
{
    public static void Main()
    {
        Console.Write("Enter age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age >= 0 && age <= 2)
            Console.WriteLine("Infant");
        else if (age >= 3 && age <= 12)
            Console.WriteLine("Child");
        else if (age >= 13 && age <= 19)
            Console.WriteLine("Teenager");
        else if (age >= 20 && age <= 64)
            Console.WriteLine("Adult");
        else if (age >= 65)
            Console.WriteLine("Senior");
        else
            Console.WriteLine("Invalid age");
    }
}