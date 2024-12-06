using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private static Random random = new Random();
    private static List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() 
        : base("Listing Activity.\n\n", "This activity will help you reflect on the good things in your life by having you list as many things as you can.\n\n") { }

    public void Run()
    {
        DisplayStartingMessage();

        string prompt = GetRandomPrompt();
        Console.Clear();
        Console.WriteLine(prompt);
        ShowCountDown(3);  // Pause for 3 seconds to think

        int timeSpent = 0;
        List<string> userList = new List<string>();

        while (timeSpent < _duration)
        {
            Console.Clear();
            Console.WriteLine("Start listing things: ");
            string userInput = Console.ReadLine();
            if (!string.IsNullOrEmpty(userInput))
            {
                userList.Add(userInput);
            }

            timeSpent += 5;  // Simulate listing items over 5 seconds
        }

        Console.WriteLine($"You listed {userList.Count} items.");
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}

