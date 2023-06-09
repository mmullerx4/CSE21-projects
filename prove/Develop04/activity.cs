using System;

class Activity
{
    protected string _startingMessage;
    protected string _endingMessage;
    protected int _duration;
    protected string _activityName;
    protected string _activityDescription;

    public Activity(string startingMsg, string endingMsg)
    {
        
        _startingMessage = startingMsg;
        _endingMessage = endingMsg;

    }

    public void getStartMsg()
    {
        Console.WriteLine($"Welcome to the {_activityName} activity.");
        Console.WriteLine($"This activity will help you {_activityDescription}");
        Console.WriteLine();
        Console.WriteLine("How long, in seconds, would you like for your activity?  ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear(); //clears the screen as program runs as example in video
        Console.WriteLine("Get ready...");
        getPauseSpinner();
    }


    public void getPauseSpinner()
    {
        DateTime futureTime = getDuration(5);
        List<string> animationStrings = new List<string>(); //creating a list variable animationStrings
        animationStrings.Add("|"); //adding an object to the list
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
  

        while (DateTime.Now <= futureTime)
        {
            foreach (string s in animationStrings) //looping the following task
            {
                Console.Write(s); //printing an object
                Thread.Sleep(250); //in second timing
                Console.Write("\b \b"); //printing within the same space with the timing above
            }
        }
    }

    public DateTime getDuration(int duration) //using DateTime as type
    {
        DateTime startTime = DateTime.Now; //declaring the current time
        DateTime futureTime = startTime.AddSeconds(duration); //Declaring the future by taking the current time and adding the user input (getDuration)
        return futureTime;
    }

    public void getPauseCounter(int duration)
    {
        //for (int i=5; i>0; i--)
        for (int i = duration; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

    }

    public void getEndMsg()
    {
        Console.WriteLine("Well done!");
        getPauseSpinner();
        Console.WriteLine($"You have completed {_duration} seconds of the {_activityName} activity.");
        getPauseSpinner();
    }


}
