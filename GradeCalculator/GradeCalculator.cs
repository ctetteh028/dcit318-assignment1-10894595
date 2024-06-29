using System;

class GradeCalculator
{
    static void Main(string[] args)
    {
        Console.Write("Enter a numerical grade between 0 and 100: ");
        string? input = Console.ReadLine();
        
        if (input != null && int.TryParse(input, out int grade) && grade >= 0 && grade <= 100)
        {
            string letterGrade;
            if (grade >= 90)
            {
                letterGrade = "A";
            }
            else if (grade >= 80)
            {
                letterGrade = "B";
            }
            else if (grade >= 70)
            {
                letterGrade = "C";
            }
            else if (grade >= 60)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
            }

            Console.WriteLine($"The letter grade for {grade} is: {letterGrade}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
        }
    }
}
