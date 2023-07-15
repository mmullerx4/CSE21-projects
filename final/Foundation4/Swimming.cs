using System;

class Swimming : Activity
{
    private int _laps;

    
    public Swimming(string date, float minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
        _activity = "Swimming";   
    }

    public override double GetDistance()
    {
        //swimming laps * 50 / 1000 * 0.62 //math from lesson
        //return _laps * 50 / 1000 * 0.62;
        //return 5; //for testing purposes
        return (_laps * 50 / _laps) % 1000; //math from Brother Parrish
    } 
}