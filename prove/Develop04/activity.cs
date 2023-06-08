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

    public void getName()
    {

    }


    public void pauseSpinner()
    {

    }

    public void getPauseCounter()
    {

    }

    public int getDuration()
    {
        return _duration;

    }

    public void goodJob()
    {
        Console.WriteLine("Well done!");
    }

}
