using System;

//Abstraction - break the program into classes
//and only what is needed for each particular class

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        video1._videoTitle = "HowTo1";
        video1._videoAuthor = "msMuller";
        video1._videoLength = "35";

        Comment v1Comment1 = new Comment();
        v1Comment1._personName = "Jake Smith";

        Comment v1Comment2 = new Comment();
        v1Comment2._personName = "Adam Smith";

        Comment v1Comment3 = new Comment();
        v1Comment3._personName = "Josiah Smith";


        Video video2 = new Video();
        video2._videoTitle = "HowTo2";
        video2._videoAuthor = "jmMuller";
        video2._videoLength = "40";

        Comment v2Comment1 = new Comment();
        v2Comment1._personName = "Nathan Adams";

        Comment v1Comment2 = new Comment();
        v2Comment2._personName = "Sam Adams";

        Comment v1Comment3 = new Comment();
        v2Comment3._personName = "Drake Adams";



        Video video3 = new Video();
        video3._videoTitle = "HowTo3";
        video3._videoAuthor = "nmMuller";
        video3._videoLength = "45";

        Comment v3Comment1 = new Comment();
        v3Comment1._personName = "Riley Baker";

        Comment v1Comment2 = new Comment();
        v3Comment2._personName = "Isabel Baker";

        Comment v1Comment3 = new Comment();
        v3Comment3._personName = "Skylar Baker";



        Video video4 = new Video();
        video4._videoTitle = "HowTo4";
        video4._videoAuthor = "msMuller";
        video4._videoLength = "50";

        Comment v4Comment1 = new Comment();
        v4Comment1._personName = "John Thomas";

        Comment v1Comment2 = new Comment();
        v4Comment2._personName = "Jacob Thomas";

        Comment v1Comment3 = new Comment();
        v4Comment3._personName = "Samuel Thomas";


        //myResume._jobs.Add(job1);
        //myResume._jobs.Add(job2);
    
        //myResume.Display();


    }
}