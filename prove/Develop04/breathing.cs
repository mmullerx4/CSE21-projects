using System;

class Breathing : Activity
{    //no attributes needed...covered under the parent
    
    //This file needs to:
    //alternating messages of breath in and breathe out with a pause until time up


    public Breathing(string activityName, string startingMsg, string endingMsg, int duration) : base (activityName, startingMsg, endingMsg, duration)
    {
        //nothing needed here because no special variables(attributes)
    }

    public void alternateBreath()
    {
        DateTime startTime = DateTime.Now; //declaring the current time
        DateTime futureTime = startTime.AddSeconds(getDuration()); //Declaring the future by taking the current time and adding the user input (getDuration)
        
        while (DateTime.Now <= futureTime) 
        {
        Console.Write("Breath in..."); //declare parameters in Activity
        getPauseCounter();
        Console.Write("Breath out...");
        getPauseCounter();
        }  

    }

}