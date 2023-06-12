using System;

class Listing : Activity
{
    //Attributes
    private Random rand = new Random();

    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    //construtor
    public Listing()
    {
        _activityName = "listing";
        _activityDescription = "reflect on the good things in your life by having you list as many things as you can in a certain area.";

    }

// This file needs to select a random prompt to show user
//(countdown after prompt)
//prompt to keep listing items until time up
//display items back to user    
    
    //methods
    public void randomPrompt()
    {   
        getStartMsg();
        
        //my list type is a string. And it is a random string from the list
        string questionObj = _prompts[rand.Next(_prompts.Count)]; //selects a random prompt
        Console.WriteLine(questionObj); //display prompt
        getPauseCounter(5); //5 sec countdown before going on
        userInput();       
    }

    string input = "";
    int counter = 0;
    public void userInput()
    {
        DateTime futureTime = getDuration(_duration);

        while (DateTime.Now <= futureTime)
        {
            Console.WriteLine("List one: "); //prompt user
            input = Console.ReadLine(); //collect user input
            counter ++;
        } 

        Console.WriteLine($"You have made {counter} entries.");

        getEndMsg();

    }
        
}