using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video v1 = new Video("Video1 Title", "Author 1", 300);
        v1.AddComment("User 1", "Great Video!");
        v1.AddComment("User 2", "I learned a lot");

        Video v2 = new Video("Video2 Title", "Author 2", 252);
        v2.AddComment("User 1", "Great Video!");
        v2.AddComment("User 2", "I learned a lot");

        Video v3 = new Video("Video3 Title", "Author 3", 340);
        v3.AddComment("User 1", "Great Video!");
        v3.AddComment("User 2", "I learned a lot");

        List<Video> videolist = new List<Video> {v1, v2, v3};

        foreach (var video in videolist)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Duration: {video.GetDuration()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumComments()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"  {comment.GetCommenterName()}: {comment.GetText()}");
            }
            Console.WriteLine("\n");
        }
    }
}