using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Console.WriteLine(); // for spacing

        //Creating videos
        Video vid1 = new Video("When do we say", "Paco your English Coach", 20);
        Video vid2 = new Video("In or On", "Paco your English Coach", 50);
        Video vid3 = new Video("Greetings in English", "Paco your English Coach", 10);

        //Add comments to vid1
        vid1.AddComment(new Comment("Jules", "I like it!"));
        vid1.AddComment(new Comment("John", "Amazing..."));
        vid1.AddComment(new Comment("Johnson", "I'd like to know more please..."));

        //Add comments to vid2
        vid2.AddComment(new Comment("Paco", "congratulations"));
        vid2.AddComment(new Comment("Grace", "sounds great..."));
        vid2.AddComment(new Comment("Sophy", "Nice"));

        //Add comments to vid3
        vid3.AddComment(new Comment("Diams", "would you give more detail please!"));
        vid3.AddComment(new Comment("Sonia", "I couldn't agree more"));
        vid3.AddComment(new Comment("Monica", "Thanks for the expalnation"));

        //Store videos in a list
        List<Video> videos = new List<Video> { vid1, vid2, vid3 };

        //Display each video's details and comments
        foreach (Video video in videos)
        {
            video.DisplayDetails();
            Console.WriteLine(); //This is for spacing
        }

    }
}