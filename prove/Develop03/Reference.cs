using System;

public class Reference
{
public string _book;
public int _chapter;
public int _verse;
public int _endVerse;

public Reference(string book, int chapter, int verse) // constructor for a single verse.
{
    _book = book;
    _chapter = chapter;
    _verse = verse;
    _endVerse = verse; // single verse.
}
public Reference(string book, int chapter, int verse, int endVerse) // constructor for a range of verse.
{
    _book = book;
    _chapter = chapter;
    _verse = verse;
    _endVerse = endVerse;
}

public string GetDisplayText() // Show the reference as a string.
{
    if(_verse == _endVerse)
    {
        return $"{_book} {_chapter}:{_verse}";
    }
    
    else
    {
        return $"{_book} {_chapter}:{_verse}-{_endVerse}";
    }
}


}