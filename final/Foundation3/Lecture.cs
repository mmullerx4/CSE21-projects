using System;

class Lecture : Event
{
    private string _eventSpeaker;
    private string _eventCapacity; //no int needed

    //constructor
    public Lecture(string eventTitle, string eventDesc, string eventDate, string eventTime, Address eventAddress, string eventSpeaker, string eventCapacity) : base(eventTitle, eventDesc, eventDate, eventTime, eventAddress)
    {
        _eventType = "Event type: Lecture";
        _eventSpeaker = eventSpeaker;
        _eventCapacity = eventCapacity;
    }


    public void fullDescription()
    {
        fullDetails();
        Console.WriteLine($"Your Lecture speaker is: {_eventSpeaker}");
        Console.WriteLine($"The Lecture capacity is: {_eventCapacity}");
    }
}