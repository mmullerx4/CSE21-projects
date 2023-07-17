using System;

class SimpleGoal : Goal
{
    //no specific attributes for this file
    //use parent attributes

    public SimpleGoal(string name,string description,int points,bool isComplete) //calling this constructor for user input
    {
            _name = name;
            _description = description;
            _points = points;
            _isComplete = isComplete;
    }

    public SimpleGoal(string typeInfo) : base(typeInfo) //calling this constructor for loading
    {
        string[] parts = typeInfo.Split(","); //taking the parts of typeInfo and splitting by commas
        _isComplete = Convert.ToBoolean(parts[3]);
    }

    public override string GetStringRepresentation()
    {
        //class name,name,description,points,False
        return $"SimpleGoal:{_name},{_description},{_points},{_isComplete}";
    }

    
}