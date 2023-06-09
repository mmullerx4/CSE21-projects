using System;

class Breathing : Activity
{    //no attributes needed...covered under the parent

    //This file needs to:
    //alternating messages of breath in and breathe out with a pause until time up


    public Breathing()
    {
        //give the attributes a value to retrieve
        _activityName = "Breathing";
        _activityDescription = "relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void alternateBreath()
    {
        getStartMsg();
        DateTime futureTime = getDuration(_duration);

        while (DateTime.Now <= futureTime)
        {
            Console.Write("Breath in..."); //declare parameters in Activity
            getPauseCounter(4);
            Console.WriteLine();
            Console.Write("Breath out...");
            getPauseCounter(6);
            Console.WriteLine();

        }

        getEndMsg();

    }

}