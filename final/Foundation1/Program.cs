using System;

    class Program
{
static void Main(string[] args)
{
// Create a list to hold the videos
List<Video> videos = new List<Video>();


        // Create and add videos to the list
        Video video1 = new Video("Funny Cats", "John Smith", 120);
        video1.AddComment("Sarah", "This video made my day!");
        video1.AddComment("Tom", "Hilarious!");
        video1.AddComment("Lisa", "I can't stop watching this!");

        videos.Add(video1);

        Video video2 = new Video("How to Bake a Cake", "Mary Johnson", 180);
        video2.AddComment("Mike", "Thanks for the recipe!");
        video2.AddComment("Anna", "I tried it and it turned out great!");
        video2.AddComment("David", "I love your cooking videos!");

        videos.Add(video2);

        Video video3 = new Video("Gardening Tips", "Jane Doe", 240);
        video3.AddComment("Kevin", "These tips are really helpful!");
        video3.AddComment("Emma", "I can't wait to try these in my garden!");
        video3.AddComment("Robert", "Thanks for sharing your knowledge!");

        videos.Add(video3);

        // Iterate through the list of videos and display information
        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length: " + video.Length + " seconds");
            Console.WriteLine("Number of Comments: " + video.GetNumberOfComments());
            Console.WriteLine("Comments:");

            // Iterate through the comments of the video and display them
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine(comment.Name + ": " + comment.Text);
            }

            Console.WriteLine(); // Add a blank line between videos
        }
    }
}

