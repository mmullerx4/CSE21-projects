using System;

class Video
{
    string _videoTitle;
    string _videoAuthor;
    int _videoLength; //in seconds
    List<Comment> customerComment = new List<Comment>();//declaring list and initializing with the " = ????" ". ()" for a new


    void nameOfComment()
    {
        
    }

    void Display()
    {
       Console.WriteLine($"{_videoTitle} {_videoAuthor} {_videoLength}"); 
    }
    
}