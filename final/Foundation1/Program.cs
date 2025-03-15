using System;

class Program
{
    static List<Video> videos = new List<Video>();

    static void DisplayVideos(List<Video> videoList)   
    {
        foreach (var video in videoList)
        {
            video.DisplayInfo();
            video.DisplayComments();
        }
    }
    static void InitializeVideos()
    {
        // Create first video
        Video video1 = new Video("C# Basics Tutorial", "CodeMaster", 600);
        video1.AddComment(new Comment("Great tutorial for beginners!", "John Doe"));
        video1.AddComment(new Comment("I learned a lot, thanks!", "Jane Smith"));
        video1.AddComment(new Comment("Could you make a follow-up on advanced topics?", "Dev123"));
        videos.Add(video1);

        // Create second video
        Video video2 = new Video("Object-Oriented Programming in C#", "ProgrammingPro", 720);
        video2.AddComment(new Comment("Your explanations are so clear!", "Sarah Johnson"));
        video2.AddComment(new Comment("This helped me understand inheritance better", "Mike Williams"));
        video2.AddComment(new Comment("Excellent content as always", "CodeNewbie"));
        video2.AddComment(new Comment("Can you cover interfaces next?", "TechEnthusiast"));
        videos.Add(video2);

        // Create third video
        Video video3 = new Video("LINQ Masterclass", "DataGeek", 540);
        video3.AddComment(new Comment("LINQ is so powerful, thanks for explaining it well", "DatabasePro"));
        video3.AddComment(new Comment("I've been using LINQ wrong all this time!", "QueryMaster"));
        video3.AddComment(new Comment("Great examples throughout", "C#Lover"));
        videos.Add(video3);

        // Create fourth video
        Video video4 = new Video("Async/Await in C#", "ThreadMaster", 900);
        video4.AddComment(new Comment("Finally understand async programming!", "AsyncBeginner"));
        video4.AddComment(new Comment("Would love to see more about Task management", "ParallelPro"));
        video4.AddComment(new Comment("This saved me hours of debugging", "ServerDev"));
        video4.AddComment(new Comment("Excellent explanation of a complex topic", "WebDeveloper"));
        videos.Add(video4);
    }

    static void Main(string[] args)
    {
        InitializeVideos();
        DisplayVideos(videos);
    }
}