using System.ComponentModel;
using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private int _duration;
    private List<Comment> _comments;

    public Video(string title, string author, int duration)
    {
        _title = title;
        _author = author;
        _duration = duration;
        _comments = new List<Comment>();
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }      
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"\nTitle: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Duration: {_duration} Seconds");
        Console.WriteLine($"Number of comments: {GetNumberOfComments()}");
    }
    public void DisplayComments()
    {
        foreach (var comment in _comments)
        {
            Console.WriteLine(comment.GetFormattedText());
        }
    } 
    
}