using System;

class Outdoor
{
    private int _weather;

    public void calcWeather()
    {

    }

    public override void standardDetails()
    {

    }

    public override void fullDetails() //include statement of weather.
    {
        Console.WriteLine($"The weather is {calcWeather()}");
        
    }

    public override void shortDesc() 
    {
        
    }
}