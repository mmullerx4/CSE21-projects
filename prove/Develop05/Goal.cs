using System;

class Goal
{
    protected string _type;
    protected string _name;
    protected string _description;
    protected int _points;

    protected bool _isComplete = false;

    public Goal()
    {
        Console.WriteLine("What is the name of your goal? ");
        _name = Console.ReadLine();
        Console.WriteLine("What is a short description of your goal? ");
        _description = Console.ReadLine();
        Console.WriteLine("What will be the number of points for this goal? ");
        _points = Convert.ToInt16(Console.ReadLine());

    }

    public void totalScore()
    {

    }

    

    public void recordEvent()
    {

    }

    public void showGoals()
    {

    }

    public void saveToFile()
    {

    }

    public void loadToFile()
    {

    }



    public virtual void isComplete()
    {
        Console.Write($"")
        
        
    }



}