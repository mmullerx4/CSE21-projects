using System;

class Activity
{
    private string _startingMessage;
    private string _endingMessage;
    private string _menu;
    private int _duration;
    private string _activityName;

    public Activity(string activityName, string startingMsg, string endingMsg, int duration)
    {
        _activityName = activityName;
        _startingMessage = startingMsg;
        _endingMessage = endingMsg;
        _duration = duration;
    
    }

    public void getActivityName()
    {
        Console.Write("_activityName");

    }


    public void getPauseSpinner()
    {
        List<string> animationStrings = new List<string>(); //creating a list variable animationStrings
        animationStrings.Add("|"); //adding an object to the list
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");

        foreach (string s in animationStrings) //looping the following task
        {
            Console.Write(s); //printing an object
            Thread.Sleep(1000); //in second timing
            Console.Write("\b \b"); //printing within the same space with the timing above
        }

    }

    public DateTime getDuration() //using DateTime as type
    {
        DateTime startTime = DateTime.Now; //declaring the current time
        DateTime futureTime = startTime.AddSeconds(_duration); //Declaring the future by taking the current time and adding the user input (getDuration)
        return futureTime;
    }

    public void getPauseCounter()
    {
        for (int i=5; i>0; i--)
        {
            Console.Write(i);
            Thread.Sleep(3000);
            Console.Write("\b \b");   
        }

    }

    
    public void goodJob()
    {
        Console.WriteLine("Well done!");
    }

}
