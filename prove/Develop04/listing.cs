using System;

class Listing
{
    private string _listingActivityName;
    private List<Listing> _list = new List<Listing>(); //using the class Listing as my type in <>
    private Random prompt = new Random();

    //construtor
    public Listing(string listingActivityName, List<> list)  ///?????
    {
        _listingActivityName = listingActivityName;
        _list = list;

    }

// This file needs to select a random prompt to show user
//(countdown after prompt)
//prompt to keep listing items until time up
//display items back to user

    public void randomPrompt()
    {
        Listing promptObj = _list[prompt.Next(_list.Count)];

    }

    public void displayList()
    {

    }


}