using System;
using System.Threading;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}{_description}");
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready to begin...");
        ShowCountDown(3);  // Pause for 3 seconds before starting the activity
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(3);  // Pause for 3 seconds before finishing
    }

    public void ShowCountDown(int seconds)
    {
         for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);  // Delay for 1 second
            Console.Write("\b \b");  // Erase last character
        }
        Console.WriteLine();
    }

    public void ShowSpinner(int seconds)
    {
        List<string>animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        
        foreach (string s in animationStrings)
        {
            Console.Write(s);
            Thread.Sleep(1000);  // Delay for 1 second
            Console.Write("\b\b");  
        }
        Console.WriteLine();
    }
}