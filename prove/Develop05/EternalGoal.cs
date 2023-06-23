using System;

class EternalGoal : Goal
{
    public EternalGoal()
    {

    }

    public void recordProgress()
    {

    }

    public void calcNumOfTimes()
    {

    }

   public override string GetStringRepresentation()
    {
        //SimpleGoal,name,description,points,False
        return $"EternalGoal,{_name},{_description},{_points},{_isComplete}";
    }

    public override void isComplete()
    {

    }
}