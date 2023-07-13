using System;

class Running : Activity
{
    private double _distance;


    public Running(string date, double minutes, int distance) : base(date, minutes)
    {
        _distance = distance;
        _activity = "Running";
    }


     //Distance (miles) = swimming laps * 50 / 1000 * 0.62
    //Speed (mph or kph) = (distance / minutes) * 60
    //Pace (min per mile or min per km)= minutes / distance
    //Speed = 60 / pace
    //Pace = 60 / speed

     public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed() // miles per hour
    {
        //Speed (mph or kph) = (distance / minutes) * 60
        return (_distance / _minutes) * 60;

    }

    public override double GetPace() //min per mile
    {
        //Pace (min per mile or min per km)= minutes / distance
        return _minutes / _distance;
    }
}