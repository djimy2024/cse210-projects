using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
        // Ask the user's first name.
        Console.Write("What is your first name?");
        string first_name = Console.ReadLine();
        // Ask the user's last name.
        Console.Write("What is your last name?");
        string last_name = Console.ReadLine();
        // Display the user's full name.
        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}.");
    }
}