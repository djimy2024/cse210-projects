// JournalApp.cs
using System;
using System.IO.Enumeration;

public class JournalMenu
{
    private Journal journal;
    private string[] prompts;

    public JournalMenu()
    {
        journal = new Journal();
        prompts = new string[]
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
    }

    // Show the menu and handle user input
    public void DisplayMenu()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Exit");
            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteNewEntry();
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    SaveToFile();
                    break;
                case "4":
                    LoadFromFile();
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option, try again.");
                    break;
            }
        }
    }

    // Write a new journal entry
    private void WriteNewEntry()
    {
        Random rand = new Random();
        int promptIndex = rand.Next(prompts.Length);
        string prompt = prompts[promptIndex];
        // Display the current date in yyyy-MM-dd format
        string date = DateTime.Now.ToShortDateString();


        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        Entry newEntry = new Entry(date, prompt, response);
        journal.AddEntry(newEntry);
        Console.WriteLine("Entry added successfully.\n");
    }

    // Save the journal to a file
    private void SaveToFile()
    {
        Console.Write("Enter filename to save journal: ");
        string filename = Console.ReadLine();
        journal.SaveFile(filename);
    }

    // Load the journal from a file
    private void LoadFromFile()
    {
        Console.Write("Enter filename to load journal: ");
        string filename = Console.ReadLine();
        journal.LoadFile(filename);
    }
}
