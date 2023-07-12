using System;

class Outdoor
{
    private int _weather;


    public Outdoor()
    {
         _eventType = "Event type: Outdoor";
    }

    public void calcWeather()
    {

    }


    public void addToOutdoor() //include statement of weather.
    {
        fullDetails();
        Console.WriteLine($"The weather is {calcWeather()}");
        
    }

}