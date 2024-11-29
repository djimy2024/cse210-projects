using System;
using System.Collections.Generic;
using System.Transactions;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");
        Comment comment1 = new Comment("Djimy", "Good job, it's very understandable.");// Create comment objects
        Video video1 = new Video("Explain Tutoring", "Leetcode", 240);  // Create video objects
        video1.AddComment(comment1);

        Comment comment2 = new Comment("Vela", "You are very simple and clear. Keep it up.");// Create comment objects
        Video video2 = new Video("Cooking Tips", "ChefCassy", 540);  // Create video objects
        video2.AddComment(comment2);
        
        Comment comment3 = new Comment("Jessy", "The best music I ever head.");// Create comment objects
        Video video3 = new Video("Music", "KonpaKreyol", 240);  // Create video objects
        video2.AddComment(comment3);
        // Store videos in a list
        List<Video> videos = new List<Video> {video1, video2, video3};

        // Iterate through the list and display each video's details
        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
    
}

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

class Video
{
 public string _title;
 public string _author;
 public int _duration;
 private List<Comment> comments = new List<Comment>();// Initialize the list of comments

 public Video(string title, string author, int duration)// constructor for Video.
 {
    _title = title;
    _author = author;
    _duration = duration;
 }

 public void AddComment(Comment comment) //Add a comment to the video
 {
   comments.Add(comment);
 }

 public int GetNumberComment()// Get the number of comments
 {
   return comments.Count;
 }

 public void DisplayVideoInfo()   //Display video details
 {
    Console.WriteLine($"Title: {_title}");
    Console.WriteLine($"Author: {_author}");
    Console.WriteLine($"Duration: {_duration}");
    Console.WriteLine($"Number of comments: {GetNumberComment()}");

    Console.WriteLine("comments: ");
    foreach(Comment comment in comments)
    {
        Console.WriteLine($" {comment}");
    }
 }
}