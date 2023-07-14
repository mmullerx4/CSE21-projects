using System;

class Swimming : Activity
{
    private int _laps;

    
    public Swimming(string date, double minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
        _activity = "Swimming";   
    }

    public override double GetDistance()
    {
        //swimming laps * 50 / 1000 * 0.62
        return _laps * 50 / 1000 * 0.62;
        //return 5; //for testing purposes
    }

    
}