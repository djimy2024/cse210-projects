using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

         // Show a base "Assignment" object
        Assignment a1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        // Show the derived class MathAssignment
        MathAssignment a2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());
          
        // Show the derived class WritingAssignment  
        WritingAssignment a3 = new WritingAssignment("Djimy Francillon", "Haiti History", "The Causes of the gangs violence");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation("Djimy Francillon"));
    }
}