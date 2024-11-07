using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        // Ask for user's grade percentage.
        Console.Write("Enter your grade percentage ");
        int gradePercentage = int.Parse(Console.ReadLine());
        string letter = "";
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >=80)
        { 
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        // Display the letter grade of the user.
        Console.WriteLine($"Your letter grade is: {letter}");
        // Determine if the user passed the course.
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course");
        }
        else
        {
            Console.WriteLine("Sorry! You did not pass the course. Please try another time.");
        }
    }
}