using System;

class Program
{
    public static void Main()
    {
        int x1 = 20, y1 = 8, x2 = 30, y2 = 18;

        double distanceSquared = Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2);
        Console.WriteLine("D^2 = " + distanceSquared);
    }
}