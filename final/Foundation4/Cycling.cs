using System;

class Cycling : Activity
{
    private double _speed;

    
    public Cycling(string date, double minutes, int speed) : base(date, minutes)
    {
        _speed = speed;
        _activity = "Cycling";
    }

    public override double GetDistance()
    {
        return (_speed / _length) * 60;
    }

    public override double GetSpeed() // miles per hour
    {
        //Speed (mph or kph) = (distance / minutes) * 60
        return (_distance / _length) * 60;
    }

    public override double GetPace() //min per mile
    {
        //Pace (min per mile or min per km)= minutes / distance

    }
}