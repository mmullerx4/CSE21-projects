using System;

class Event
{
    private string _eventTitle;
    private string _eventDesc;
    private string _eventDate; //"int" type not needed
    private string _eventTime;
    private string _eventAddress;
    protected string _eventType;

    
    public Event(string eventTitle, string eventDesc, string eventDate, string eventTime, string eventAddress)
    {
        _eventTitle = eventTitle;
        _eventDesc = eventDesc;
        _eventDate = eventDate;
        _eventTime = eventTime;
        _eventAddress = eventAddress;
    }

    public virtual void standardDetails() //Lists the title, description, date, time, and address
    {
        Console.WriteLine(_eventTitle);
        Console.WriteLine(_eventDesc);
        Console.WriteLine(_eventDate);
        Console.WriteLine(_eventTime);
        Console.WriteLine(_eventAddress);

    }

    public virtual void fullDetails() //Lists the title, desc., date, time, and address plus type of event and specifics
    {
        Console.WriteLine(_eventTitle);
        Console.WriteLine(_eventDesc);
        Console.WriteLine(_eventDate);
        Console.WriteLine(_eventTime);
        Console.WriteLine(_eventAddress);
        Console.WriteLine(_eventType);

    }

    public virtual void shortDesc() //Lists the type of event, title, and the date
    {
        Console.WriteLine(_eventType);
        Console.WriteLine(_eventTitle);
        Console.WriteLine(_eventDate);
        
    }
}