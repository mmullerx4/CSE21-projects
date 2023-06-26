using System;

abstract class Goal
{
    protected string _type;
    protected string _name;
    protected string _description;
    protected int _points;

    protected static int _totalPoints; //static means only one copy not for each file or instance

    protected bool _isComplete = false;

    public Goal()
    {
       

    }

    public void totalScore()
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


    public void recordEvent()
    {

    }



    public virtual void isComplete()
    {
        
        
    }



}