using System;

class SimpleGoal : Goal
{
    //no specific attributes for this file
    //use parent attributes

    public SimpleGoal(string name,string description,int points,bool isComplete)
    {
            _name = name;
            _description = description;
            _points = points;
            _isComplete = isComplete;
    }
    public override string GetStringRepresentation()
    {
        //class name,name,description,points,False
        return $"SimpleGoal,{_name},{_description},{_points},{_isComplete}";
    }

    public override void recordEvent(ref int _totalPoints)
    {
        _totalPoints += _points;    
    }

    

}