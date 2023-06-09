using System;

class Listing : Activity
{
    
    private Random rand = new Random();

    private List<string> _prompts = new List<string>()
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
        _activityDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

    }

// This file needs to select a random prompt to show user
//(countdown after prompt)
//prompt to keep listing items until time up
//display items back to user    
    
    
    public void randomPrompt()
    {   //my list type is a string. And it is a random string from the list
          
        getStartMsg();
        DateTime futureTime = getDuration(_duration);

        while (DateTime.Now <= futureTime)
        {
            //my list type is a string. And it is a random string from the list
            string questionObj = _prompts[rand.Next(_prompts.Count)];
            Console.WriteLine(questionObj);
            getPauseCounter(5);
            
        }    
        getEndMsg();
    }

    string input = "";
    int counter = 0;
    public void userInput()
    {
        input = Console.ReadLine();
        counter ++;

    }
            

    public void displayList()
    {
        Console.WriteLine("You have made {} amount of entries.");

    }

}