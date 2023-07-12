using System;

class Event
{
    private string _eventTitle;
    private string _eventDesc;
    private string _eventDate; //"int" type not needed
    private string _eventTime;
    private Address _eventAddress;
    protected string _eventType;

    
    public Event(string eventTitle, string eventDesc, string eventDate, string eventTime, Address eventAddress)
    {
        _eventTitle = eventTitle;
        _eventDesc = eventDesc;
        _eventDate = eventDate;
        _eventTime = eventTime;
        _eventAddress = eventAddress;
    }

    public void standardDetails() //Lists the title, description, date, time, and address
    {
        Console.WriteLine("Standard Details");
        Console.WriteLine(_eventTitle);
        Console.WriteLine(_eventDesc);
        Console.WriteLine(_eventDate);
        Console.WriteLine(_eventTime);
        _eventAddress;
    }

    protected void fullDetails() //Lists the title, desc., date, time, and address plus type of event and specifics
    {
        Console.WriteLine("Full Details");
        Console.WriteLine(_eventTitle);
        Console.WriteLine(_eventDesc);
        Console.WriteLine(_eventDate);
        Console.WriteLine(_eventTime);
        Console.WriteLine(_eventAddress);
    }

    public void shortDesc() //Lists the type of event, title, and the date
    {
        Console.WriteLine("Short Description");
        Console.WriteLine(_eventType);
        Console.WriteLine(_eventTitle);
        Console.WriteLine(_eventDate);  
    }
}