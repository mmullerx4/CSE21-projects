using System;

class Listing
{
    
    private List<string> _list = new List<string>(); //using the class Listing as my type in <>
    private Random rand = new Random();

    private List<string> _prompt = new List<string>()
    {
        x, x, x, x
    }

    //construtor
    public Listing(string activityName)  : base(activityName)
    {
        _listingActivityName = listingActivityName;

    }

// This file needs to select a random prompt to show user
//(countdown after prompt)
//prompt to keep listing items until time up
//display items back to user

    get userInput()
    {

    }
    
    public void randomPrompt()
    {   //my list type is a string. And it is a random string from the list
        string promptObj = _list[rand.Next(_list.Count)];
        
    }

    public void displayList()
    {

    }


}