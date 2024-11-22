using System;
using System.Collections.Generic;


public class Scripture
{

    public Reference reference;
    public List<Word> words;

    public Scripture(Reference _reference, string text)
    {
        reference = _reference;
        words = new List<Word>();
        // Split the text into words and create Word objects
        foreach (var word in text.Split(' '))
        {
            words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int NumberToHide)
    {
        Random rand = new Random();
        int wordsToHide = Math.Min(NumberToHide, words.Count); // Can't hide more words than exist

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = rand.Next(words.Count);
            words[index].Hide(); // Hide the randomly chosen word
        }
    }

     public string GetDisplayText()
    {
        List<string> wordTexts = new List<string>();
        foreach (var word in words)
        {
            wordTexts.Add(word.GetDisplayText());
        }
        return $"{reference.GetDisplayText()} " + string.Join(" ", wordTexts);
    }

}