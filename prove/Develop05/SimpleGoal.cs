using System;

class SimpleGoal : Goal
{
    //no specific attributes for this file
    //use parent attributes

    public SimpleGoal()
    {
        
        

    }
    public override string GetStringRepresentation()
    {
        //SimpleGoal,name,description,points,False
        return $"SimpleGoal,{_name},{_description},{_points},{_isComplete}";
    }

    public override void isComplete()
    {


    }

}