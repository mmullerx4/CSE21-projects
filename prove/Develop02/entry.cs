using System;

class Entry
{
    string randomPrompt;
    string userResponse; //creating the variable
    string entryDate;
    public string writeEntry() 
    {

    string[] randomPrompt = new string[5] { 
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What did I learn today?",
        "What would I have done better today?"
        };

    Random rand = new Random();
    string randomValue = randomPrompt[rand.Next(0, randomPrompt.Length)]; //storing a variable based on someone else's code
    Console.WriteLine(randomPrompt);

    userResponse = Console.ReadLine(); //not creating the variable but referencing the variable

    DateTime theCurrentTime = DateTime.Now; 
    entryDate = theCurrentTime.ToShortDateString();                                       
    //green is a class or built-in class, lt. blue is variable name or built-in variable
    //"theCurrentTime" variable can be replace with any name. ".Now" is attribute
    //"DateTime" is someone else's (MS?) code.
    //lt. yellow are methods or built-in method
    
    }
   
}