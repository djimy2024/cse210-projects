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