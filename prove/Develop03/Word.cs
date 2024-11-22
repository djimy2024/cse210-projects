using System;
using System.Collections.Generic;

public class Word
{ 
    public string _text;
    public bool _IsHidden;


    public Word(string text)
    {
       _text = text;
       _IsHidden = false;
    }

     public void Hide()
    {
        _IsHidden = true;
    }
    // Get the word as text or as underscores if hidden
    public string GetDisplayText()
    {
        return _IsHidden ? new string('_', _text.Length) : _text;
    }


}