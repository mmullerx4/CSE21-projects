using System;

class EternalGoal : Goal
{
    public EternalGoal(string name,string description,int points)
    {
        _name = name;
        _description = description;
        _points = points;

    }

    public EternalGoal(string typeInfo) : base(typeInfo) //calling this constructor for loading
    {
        
    }

   
   public override string GetStringRepresentation()
    {
        //SimpleGoal,name,description,points,False
        return $"EternalGoal:{_name},{_description},{_points}";
    }

}