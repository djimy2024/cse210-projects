using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private static Random random = new Random();
    private static List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private static List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?"
    };

    public ReflectingActivity() 
        : base("Reflection Activity.\n\n", "This activity will help you reflect on times in your life when you have shown strength and resilience.\n\n") { }

    public void Run()
    {
        DisplayStartingMessage();

        string prompt = GetRandomPrompt();
        Console.Clear();
        Console.WriteLine(prompt);
        ShowCountDown(3);  // Pause for 3 seconds for reflection

        int timeSpent = 0;
        while (timeSpent < _duration)
        {
            string question = GetRandomQuestion();
            Console.Clear();
            Console.WriteLine(question);
            ShowSpinner(3);  // Simulate thinking time with a spinner

            timeSpent += 3;  // Each question takes 3 seconds
        }

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        int index = random.Next(_questions.Count);
        return _questions[index];
    }
}
