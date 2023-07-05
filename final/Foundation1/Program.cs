using System;

//Abstraction - breaking the program into chunks or classes
//and only what is needed for each particular class within that class
//this makes it easy to go back to look at your code or find a particular part of the code

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        video1._videoTitle = "HowTo1";
        video1._videoAuthor = "msMuller";
        video1._videoLength = 35;

        Comment v1Comment1 = new Comment();
        v1Comment1._personName = "Jake Smith";
        v1Comment1._textComment = "This is Jake's comments";

        Comment v1Comment2 = new Comment();
        v1Comment2._personName = "Adam Smith";
        v1Comment2._textComment = "This is Adams's comments";

        Comment v1Comment3 = new Comment();
        v1Comment3._personName = "Josiah Smith";
        v1Comment3._textComment = "This is Josiah's comments";


        Video video2 = new Video();
        video2._videoTitle = "HowTo2";
        video2._videoAuthor = "jmMuller";
        video2._videoLength = 40;

        Comment v2Comment1 = new Comment();
        v2Comment1._personName = "Nathan Adams";
        v2Comment1._textComment = "This is Nathan's comments";

        Comment v2Comment2 = new Comment();
        v2Comment2._personName = "Sam Adams";
        v2Comment2._textComment = "This is Sam's comments";

        Comment v2Comment3 = new Comment();
        v2Comment3._personName = "Drake Adams";
        v2Comment3._textComment = "This is Drake's comments";



        Video video3 = new Video();
        video3._videoTitle = "HowTo3";
        video3._videoAuthor = "nmMuller";
        video3._videoLength = 45;

        Comment v3Comment1 = new Comment();
        v3Comment1._personName = "Riley Baker";
        v3Comment1._textComment = "This is Riley's comments";

        Comment v3Comment2 = new Comment();
        v3Comment2._personName = "Isabel Baker";
        v3Comment2._textComment = "This is Isabel's comments";

        Comment v3Comment3 = new Comment();
        v3Comment3._personName = "Skylar Baker";
        v3Comment3._textComment = "This is Skylar's comments";



        Video video4 = new Video();
        video4._videoTitle = "HowTo4";
        video4._videoAuthor = "msMuller";
        video4._videoLength = 50;

        Comment v4Comment1 = new Comment();
        v4Comment1._personName = "John Thomas";
        v4Comment1._textComment = "This is John's comments";

        Comment v4Comment2 = new Comment();
        v4Comment2._personName = "Jacob Thomas";
        v4Comment2._textComment = "This is Jacob's comments";

        Comment v4Comment3 = new Comment();
        v4Comment3._personName = "Samuel Thomas";
        v4Comment3._textComment = "This is Samuel's comments";


        //public List<Job> _jobs = new List<Job>(); ...from resume file
        //myResume._jobs.Add(job1);
        //myResume._jobs.Add(job2);
    
        //myResume.Display();

        // List<Comment> customerComment = new List<Comment>(); ...from video file
        video1.customerComment.Add(v1Comment1); //adding comment 1 to video1
        video1.customerComment.Add(v1Comment2);
        video1.customerComment.Add(v1Comment3);

        
        video2.customerComment.Add(v2Comment1); 
        video2.customerComment.Add(v2Comment2);
        video2.customerComment.Add(v2Comment3);

        video3.customerComment.Add(v3Comment1); 
        video3.customerComment.Add(v3Comment2);
        video3.customerComment.Add(v3Comment3);

        video4.customerComment.Add(v4Comment1); 
        video4.customerComment.Add(v4Comment2);
        video4.customerComment.Add(v4Comment3);


        List<Video> videos = new List<Video>(); //no public or private in program.cs

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);


        foreach (Video video in videos) //specify class/dataType then the variable
        {
            video.Display(); //using new variable call the public Display function from Video.cs

        }

    }
}