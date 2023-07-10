using System;

class Activity
{
    private int _date;
    private int _length;
    List<Activity> activityList = new List<Activity>(); //declaring attribute and initializing

    
    //Distance (km) = swimming laps * 50 / 1000
    //Distance (miles) = swimming laps * 50 / 1000 * 0.62
    //Speed (mph or kph) = (distance / minutes) * 60
    //Pace (min per mile or min per km)= minutes / distance
    //Speed = 60 / pace
    //Pace = 60 / speed

    public virtual void GetDistance()
    {
        return distance = speed * time;

    }

    public virtual int GetSpeed() // miles per hour
    {
        return distance / minutes * 60; //mph * minute

    }

    public virtual void GetPace() //min per mile
    {
        minutes / distance;

    }

    public virtual void GetSummery()
    {
        
    }
}