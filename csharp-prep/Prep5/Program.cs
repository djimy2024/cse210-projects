using System;
using System.Globalization;

class Program
{
           
    
    static void DisplayWelcome() // Function to display a welcome message.
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName() // Function that ask the name of the user.
    {
        Console.Write("Please enter your name:");
        return Console.ReadLine();
    }

    static int PromptUserNumber() // Function that ask the favorite number of the user.
    {
        Console.Write("Please enter your favorite number:");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber (int number) // Function that ask aquare the favorite number of the user.
    {
      return number * number;
    }

    static void DisplayResult(string name, int SquareNumber) // Function that display the name and the squarenumber.
    {
        Console.WriteLine($"{name}, the square of your number is {SquareNumber}");
    }

    static void Main(string[] args)
    {   
        // Display welcome message.
        DisplayWelcome();
        // The user name.
        string UserName = PromptUserName();
        // The user favoirite number.
        int UserNumber = PromptUserNumber();
        // Square of the user favoirite number.
        int SNumber = SquareNumber(UserNumber);
        // Display the name of the user and his favorite square number.
        DisplayResult(UserName, SNumber);
    }
}