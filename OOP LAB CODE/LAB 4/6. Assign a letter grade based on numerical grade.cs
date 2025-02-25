using System;

class Program
{
    public static void Main()
    {
        Console.Write("Enter numerical grade: ");
        int grade = Convert.ToInt32(Console.ReadLine());
        char letterGrade = 'O';

        if (grade > 100)
            Console.WriteLine("Mark is Invalid for grading");
        else if (grade >= 90 && grade <= 100)
            letterGrade = 'A';
        else if (grade >= 80)
            letterGrade = 'B';
        else if (grade >= 70)
            letterGrade = 'C';
        else if (grade >= 60)
            letterGrade = 'D';
        else
            letterGrade = 'F';

        Console.WriteLine("Letter Grade: " + letterGrade);
    }
}