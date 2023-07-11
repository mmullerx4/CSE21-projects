using System;

class Entry
{
    public string _randomValue;  //prompt from random prompt
    public string _userResponse; //creating the variable for user response
    public string _entryDate;

    
    public void writeEntry() 
    {

    string[] _randomPrompt = new string[5] {             //creating an array for random prompt of 5 objects
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What did I learn today?",
        "What would I have done better today?"
        };


    Random rand = new Random();
    _randomValue = _randomPrompt[rand.Next(0, _randomPrompt.Length)]; //storing a variable based on someone else's code
    Console.WriteLine(_randomValue);

    _userResponse = Console.ReadLine(); //referencing the variable and collecting info in variable

    DateTime theCurrentTime = DateTime.Now; 
    _entryDate = theCurrentTime.ToShortDateString();                                       
    //green is a class or built-in class, lt. blue is variable name or built-in variable
    //"theCurrentTime" variable can be replace with any name. ".Now" is attribute
    //"DateTime" is someone else's (MS?) code.
    //lt. yellow are methods or built-in method
    
    }
   
}