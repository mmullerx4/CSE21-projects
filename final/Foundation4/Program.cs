using System;

class Program
{
    //4th principle of programming with classes or object-oriented programming (OOP)
    //Polymorphism - using inheritance and setting virtual and overriding methods

    //For customers to track their exercise
    //write a program that creates at least one activity of each type. Put each of these activities
    //in the same list. Then iterate through this list and call the GetSummary method on each item
    //and display the results.

    static void Main(string[] args)
    {
        List<Activity> activityList = new List<Activity>(); //declaring attribute and initializing

        
        Running running01 = new Running("11 July 2023", 50, 5);//date,length, distance
        activityList.Add(running01); //adding to the activity list with the Add function 

        Cycling cycling01 = new Cycling("12 July 2023", 120, 30);
        activityList.Add(cycling01);
        

        Swimming swimming01 = new Swimming("13 July 2023", 60, 30);
        activityList.Add(swimming01);

        foreach (Activity _activity in activityList)
        {
            Console.WriteLine();
            _activity.GetSummery();
            Console.WriteLine();
        }
     
    }
}