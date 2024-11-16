// Journal.cs
using System;
using System.Collections.Generic;
using System.IO;


public class Journal
{
    public List<Entry> entries = new List<Entry>();
    
    // Add a new entry to the journal
    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    // Display all entries
    public void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries to display.");
            return;
        }

        foreach (var entry in entries)
        {
            entry.DisplayEntry();
        }
    }

    // Save the journal to a file
    public void SaveFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry._date} ~|~ {entry._prompt} ~|~ {entry._response}");
            }
        }
        Console.WriteLine("Journal saved successfully.");
    }

    // Load the journal from a file
    public void LoadFile(string filename)
    {
        //string filename = "myFile.txt";
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename); // Read all lines from the file

        foreach (var line in lines)
        {
            string[] parts = line.Split("~|~");  
            if (parts.Length == 3) // We expect three parts: Date, Prompt, and Response
            {
                string date = parts[0];
                string prompt = parts[1];
                string response = parts[2];

                // Create a new entry and add it to the journal
                Entry entry = new Entry(date, prompt, response);
                entries.Add(entry);
            }
        }
        Console.WriteLine("Journal loaded successfully.");
    }
}
