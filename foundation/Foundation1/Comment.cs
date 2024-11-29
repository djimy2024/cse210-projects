class Comment
{
  public string _text;
  public string _commentName;

  public Comment(string text, string commentName)//constructor for Comment.
  {
    _text = text;
    _commentName = commentName;
  }

   // Method to display comment details
    public override string ToString()
    {
        return $"{_commentName}: {_text}";
    }

}
