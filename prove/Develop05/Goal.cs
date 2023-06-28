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

    public abstract void recordEvent(ref int _totalPoints); //ref allows to access and modify from program.cs

    public int GetPoints()
    {
        return _points;       
    }

    //public virtual void isComplete()
    //{
        
        
   // }

}