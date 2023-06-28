using System;

class EternalGoal : Goal
{
    public EternalGoal(string name,string description,int points)
    {
        _name = name;
        _description = description;
        _points = points;

    }

   

   public override string GetStringRepresentation()
    {
        //SimpleGoal,name,description,points,False
        return $"EternalGoal,{_name},{_description},{_points}";
    }

    public override void recordEvent(ref int _totalPoints)
    {
        _totalPoints += _points;
        
    }

}