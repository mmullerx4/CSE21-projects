using System;

class Outdoor : Event
{
    private string _weather;


    public Outdoor(string eventTitle, string eventDesc, string eventDate, string eventTime, Address eventAddress, string weather) : base(eventTitle, eventDesc, eventDate, eventTime, eventAddress)
    {
         _eventType = "Event type: Outdoor";
         _weather = weather;
    }


    public void fullDescription() //include statement of weather.
    {
        fullDetails();
        Console.WriteLine($"The weather is {_weather}"); 
    }
}