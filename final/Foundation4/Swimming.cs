using System;

class Swimming : Activity
{
    private int _laps;

    
    public Swimming(string date, double minutes, int laps) : base(date, minutes)
    {
        _activity = "Swimming";
        
    }


    public override double GetDistance()
    {
        //Distance (km) = swimming laps * 50 / 1000
        return _laps * (50 / 1000);
    }


   public override double GetSpeed() // miles per hour
    {
        //Speed (mph or kph) = (distance / minutes) * 60
        return ()

    }

    public override double GetPace() //min per mile
    {
        //Pace (min per mile or min per km)= minutes / distance

    }
}