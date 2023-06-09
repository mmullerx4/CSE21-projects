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
        DateTime futureTime = getDuration();
               
                while (DateTime.Now <= futureTime)
                {
                    Console.Write("Breath in..."); //declare parameters in Activity
                    getPauseCounter();
                    Console.Write("Breath out...");
                    getPauseCounter();

                } 
          

    }

}