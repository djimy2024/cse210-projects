using System;
using System.Collections.Generic;


class Scriptures
{
    static void Main(string[] args)
    {
        // Create a reference for the scripture
        Reference reference = new Reference("Matthew", 7, 7);

        // Create a scripture with the reference and the text
        Scripture scripture = new Scripture(reference, "Ask, and it shall be given you; seek, and ye shall find; knock, and it shall be opened unto you.");

        // Display the initial scripture
        Console.WriteLine("Original Scripture:");
        Console.WriteLine(scripture.GetDisplayText());

        // Hide 3 random words
        scripture.HideRandomWords(3);

        // Display the scripture with some words hidden
        Console.WriteLine("\nScripture after hiding words:");
        Console.WriteLine(scripture.GetDisplayText());

        // Hide 2 more random words
        scripture.HideRandomWords(2);

        // Display the scripture after more words are hidden
        Console.WriteLine("\nScripture after hiding more words:");
        Console.WriteLine(scripture.GetDisplayText());
    }
}



public class Reference
{
    public string _Book;
    public int _Chapter; 
    public int _Verse; 
    public int _EndVerse; 

    // Constructor for a single verse
    public Reference(string book, int chapter, int startVerse)
    {
        _Book = book;
        _Chapter = chapter;
        _Verse = startVerse;
        _EndVerse = startVerse; // Single verse
    }

    // Constructor for a range of verses
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _Book = book;
        _Chapter = chapter;
        _Verse = startVerse;
        _EndVerse = endVerse;
    }

    // Get the reference as a string, e.g., John 3:16 or Proverbs 3:5-6
    public string GetDisplayText()
    {
        if (_Verse == _EndVerse)
        {
            return $"{_Book} {_Chapter}:{_Verse}";
        }
        else
        {
            return $"{_Book} {_Chapter}:{_Verse}-{_EndVerse}";
        }
    }
}


public class Word
{
    public string _Text; 
    public bool _IsHidden;

    // Constructor for a single word
    public Word(string text)
    {
        _Text = text;
        _IsHidden = false; // Words are visible by default
    }

    // Hide the word by marking it as hidden
    public void Hide()
    {
        _IsHidden = true;
    }

    // Get the word as text or as underscores if hidden
    public string GetDisplayText()
    {
        return _IsHidden ? new string('_', _Text.Length) : _Text;
    }
}



public class Scripture
{
    public Reference Reference;
    public List<Word> Words;

    // Constructor that accepts the reference and the scripture text
    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Words = new List<Word>();
        // Split the text into words and create Word objects
        foreach (var word in text.Split(' '))
        {
            Words.Add(new Word(word));
        }
    }

    // Hide a random number of words from the scripture
    public void HideRandomWords(int count)
    {
        Random rand = new Random();
        int wordsToHide = Math.Min(count, Words.Count); // Can't hide more words than exist

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = rand.Next(Words.Count);
            Words[index].Hide(); // Hide the randomly chosen word
        }
    }

    // Get the full scripture with words displayed or hidden
    public string GetDisplayText()
    {
        List<string> wordTexts = new List<string>();
        foreach (var word in Words)
        {
            wordTexts.Add(word.GetDisplayText());
        }
        return $"{Reference.GetDisplayText()}: " + string.Join(" ", wordTexts);
    }
}


