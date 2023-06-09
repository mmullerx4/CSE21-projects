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
    public Listing(string activityName, string startingMsg, string endingMsg, int duration)  : base(activityName, startingMsg, endingMsg, duration)
    {
        //info not needed here - we don't need plug in any parameters... already there in attribute above

    }

// This file needs to select a random prompt to show user
//(countdown after prompt)
//prompt to keep listing items until time up
//display items back to user

         
        
            
    
    
    public void randomPrompt()
    {   //my list type is a string. And it is a random string from the list
        string promptObj = _prompts[rand.Next(_prompts.Count)];
        getPauseCounter();      
    }

    public void userInput()
            {
                DateTime futureTime = getDuration();
               
                while (DateTime.Now <= futureTime)
                {

                }
            
                getPauseCounter();
                Console.ReadLine();
            } 

    public void displayList()
    {
        Console.WriteLine("You have made {} amount of entries.");

    }


}