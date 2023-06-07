using System;

class Activity
{
    private string _startingMessage;
    private string _endingMessage;
    private string _menu;
    private int _duration;

    public Activity(string startingMsg, string endingMsg, string menu, int duration)
    {
        _startingMessage = startingMsg;
        _endingMessage = endingMsg;
        _menu = menu;
        _duration = duration;
    }

    public void displayMenu()
    {
        Console.WriteLine(_menu);
    }

    public void pauseSpinner()
    {

    }

    public void pauseCounter()
    {

    }

    public void goodJob()
    {
        Console.WriteLine("Well done!");
    }

}
