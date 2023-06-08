using System;

class Breathing
{    //no attributes needed...covered under the parent
    
    //This file needs to:
    //alternating messages of breath in and breathe out with a pause until time up


    public Breathing(activityName) : base (activityName)
    {
        //nothing needed here because no special variables(attributes)
    }

    public void alternateBreath()
    {
        while (getDuration();)
        {
        Console.Write("Breath in...");
        getPauseCounter(3);
        Console.Write("Breath out...");
        getPauseCounter(6);
        }
        

    }


}