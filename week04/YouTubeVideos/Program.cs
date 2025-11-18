class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video v1 = new Video("How Widgets Work", "WidgetCorp", 240);
        v1.AddComment(new Comment("Aisha", "Very informative!"));
        v1.AddComment(new Comment("Derek", "Loved the visuals."));
        v1.AddComment(new Comment("Priya", "Could you do a part 2?"));
        videos.Add(v1);

        // Video 2
        Video v2 = new Video("Quick Tips for Productivity", "Sam T.", 180);
        v2.AddComment(new Comment("Moses", "Thanks for the tips."));
        v2.AddComment(new Comment("Lana", "I use #3 already!"));
        v2.AddComment(new Comment("Chen", "Great pacing."));
        videos.Add(v2);

        // Video 3
        Video v3 = new Video("Cooking Basics: Knife Skills", "Chef Ana", 360);
        v3.AddComment(new Comment("Jordan", "Hands-on and useful."));
        v3.AddComment(new Comment("Elena", "My chopping improved a lot."));
        v3.AddComment(new Comment("Harun", "Nice explanation of techniques."));
        v3.AddComment(new Comment("Rita", "Subtitles would be helpful."));
        videos.Add(v3);

        // Video 4
        Video v4 = new Video("Intro to C# Classes", "CodeAcademy", 420);
        v4.AddComment(new Comment("Sam", "Clear explanation."));
        v4.AddComment(new Comment("Ife", "Very helpful for beginners."));
        v4.AddComment(new Comment("Tom", "Would love exercises."));
        videos.Add(v4);

        // Display each video and its comments
        Console.WriteLine("YouTube Videos Report\n---------------------\n");
        foreach (var video in videos)
        {
            video.Display();
        }

        Console.WriteLine("End of report. Press any key to exit...");
        Console.ReadKey();
    }
}
