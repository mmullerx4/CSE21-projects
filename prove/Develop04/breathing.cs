using System;

class Breathing : Activity
{    //no attributes needed...covered under the parent

    //This file needs to:
    //alternating messages of breath in and breathe out with a pause until time up


    public Breathing() //parameters not needed because value enetered on line 13 & 14
    {
        //give the attributes a value to retrieve
        _activityName = "Breathing";
        _activityDescription = "relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void alternateBreath()
    {
        getStartMsg(); //calling method from activity file
        DateTime futureTime = getDuration(_duration);

        while (DateTime.Now <= futureTime)
        {
            Console.Write("Breath in..."); //declare parameters in Activity
            getPauseCounter(5);
            Console.WriteLine();
            Console.Write("Breath out...");
            getPauseCounter(8);
            Console.WriteLine();

        }

        getEndMsg(); //calling method from activity file
    }
}