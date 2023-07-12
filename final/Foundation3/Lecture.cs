using System;

class Lecture
{
    private string _eventSpeaker;
    private string _eventCapacity;

    //constructor
    public Lecture()
    {
        _eventType = "Event type: Lecture";
    }


    public override void addToFullLecture()
    {
        fullDetails();
        Console.WriteLine(_eventSpeaker);
        Console.WriteLine(_eventCapacity);
    }

}