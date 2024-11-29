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


