using System;

abstract class Goal
{
    protected string _type;
    protected string _name;
    protected string _description;
    protected int _points; //this cannot be static because each children will have different copy of points

    //protected static int _totalPoints; //static variable means only one copy not for each file or instance
    //this allows for all instances to be added or totaled
    //but this needs to move to the program.cs as a local variable in order to fix the goals index as not exist

    protected bool _isComplete = false;

    public Goal() //constructor is not needed here. Could be deleted.
    {
       
    }

    public Goal(string typeInfo) //new constructor naming a parameter anything I want. I choose to call it the same as my info on program
    {
        string[] parts = typeInfo.Split(","); //taking the parts of typeInfo and splitting by commas
        _name = parts[0];
        _description = parts[1];
        _points = Convert.ToInt16(parts[2]);
    }

    public virtual void displayGoals(int goalNum) //naming a new variable needed for this method to complete the action
    {
         
         string _blankCheck = "[ ]";
         string _check = "[x]";


        if (_isComplete == false)
        {
            Console.WriteLine($" {goalNum}. {_name} {_blankCheck} ({_description})");
        }
        else
        {
            Console.WriteLine($"{goalNum}. {_name} {_check} ({_description})");
        }

    }

    public abstract string GetStringRepresentation();
    //abstract means every file will be different with a string for saving in the file 

    public virtual void recordEvent(ref int _totalPoints) //ref allows to access and modify from program.cs
    {
        _totalPoints += _points;
    }
    public int GetPoints()
    {
        return _points;       
    }

}