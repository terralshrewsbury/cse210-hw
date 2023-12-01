using System.Transactions;
using System.Collections.Generic;

class Video
{
    private string _title {get; set; }
    private string _author {get; set; }
    private int _length {get; set; } //in seconds
    private List<Comment> Comments {get; set; }

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;//in seconds
        Comments = new List<Comment>();
    }    
    public void AddComments(string commenterName, string commentText)
    {
        Comment comment = new Comment(commenterName, commentText);
        Comments.Add(comment);
    }
    public int GetNumberOfComments()
    {
        return Comments.Count;
    }
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of Comment: {GetNumberOfComments()}");
        Console.WriteLine("Comments: ");
        foreach(var comment in Comments)
        {
            Console.WriteLine($"- {comment.CommenterName}: {comment.CommentText}");
        }
        Console.WriteLine();
    }
}
