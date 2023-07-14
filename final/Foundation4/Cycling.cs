using System;

class Cycling : Activity
{
    private double _speed;

    
    public Cycling(string date, double minutes, int speed) : base(date, minutes)
    {
        _speed = speed;
        _activity = "Cycling";
    }

    public override double GetDistance() //if void no one can use it
    {
        return (_speed / _minutes) * 60;
    }

}