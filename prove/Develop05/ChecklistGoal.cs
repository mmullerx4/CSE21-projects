using System;

class CheckListGoal : Goal
{
    private int _bonusPoints;
    private int _numCompleted = 0;
    private int _totalToComplete;

    public CheckListGoal(string name,string description,int points,int bonusPoints,int numCompleted, int totalToCompleted)
    {
        _name = name;
        _description = description;
        _points = points;
        _bonusPoints = bonusPoints;
        _numCompleted = numCompleted;
        _totalToComplete = totalToCompleted;

    }

    public void recordPartialGoal()
    {

    }

    public void bonusGoalComplete()
    {

    }

    public override void displayGoals(int goalNum)
    {
        string _blankCheck = "[ ]";
        string _check = "[x]";



        if (_isComplete == false)
        {
            Console.WriteLine($" {goalNum}. {_name} {_blankCheck} ({_description}) -- Currently completed: {_numCompleted}/{_totalToComplete}");
        }
        else
        {
            Console.WriteLine($"{goalNum}. {_name} {_check} ({_description})");
        }
    }

   public override string GetStringRepresentation()
    {
        //SimpleGoal,name,description,points,False
        
        return $"CheckListGoal,{_name},{_description},{_points},{_bonusPoints},{_numCompleted},{_totalToComplete}";
    }
    public override void isComplete()
    {

    }
}