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

        
        Running running01 = new Running("11 July 2023", 50.5, 5);//date,length, distance
        running01.GetDistance();
        running01.GetSpeed();
        running01.GetPace();
        running01.GetSummery();

        Cycling cycling01 = new Cycling("12 July 2023", 120, 30);
        cycling01.GetDistance();
        cycling01.GetSpeed();
        cycling01.GetPace();
        cycling01.GetSummery();

        Swimming swimming01 = new Swimming("13 July 2023", 60, 25);
        swimming01.GetDistance();
        swimming01.GetSpeed();
        swimming01.GetPace();
        swimming01.GetSummery();
    }
}