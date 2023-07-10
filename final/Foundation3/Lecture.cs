using System;

class Lecture
{
    private string _eventSpeaker;
    private string _eventCapacity;

    public override void standardDetails()
    {

    }

    public override void fullDetails() //include speaker name and capacity
    {
        Console.WriteLine(_eventTitle);
        Console.WriteLine(_eventDesc);
        Console.WriteLine(_eventDate);
        Console.WriteLine(_eventTime);
        Console.WriteLine(_eventAddress);
        Console.WriteLine(_eventType);
        Console.WriteLine(_eventSpeaker);
        Console.WriteLine(_eventCapacity);
        
    }

    public override void shortDesc()
    {
        
    }
}