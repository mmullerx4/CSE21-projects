using System;

class Video
{
    public string _videoTitle;
    public string _videoAuthor;
    public int _videoLength; //in seconds
    public List<Comment> customerComment = new List<Comment>();//declaring list and initializing with the " = ????" ". ()" for a new


    public int numOfComments()
    {
        return customerComment.Count;     
    }

    public void Display()
    {
        Console.WriteLine($"The number of comments: {numOfComments()}");
        
       foreach (Comment comment in customerComment) //data type is "Comment" ...because my classes are datatypes
       {
        Console.WriteLine($"Video Title: {_videoTitle} Video Author: {_videoAuthor} Video Length: {_videoLength} sec.");
        Console.WriteLine(comment.textComment());
        Console.WriteLine();
       }
       
    
    }

}