using System;

//Inheritance
//derived (child) classes can inherit code from base (parent) class

//This program helps to organize market events throughout the world
//track each event and produce marketing material to distribute on social media

//create one event for each type and set values

class Program
{
    static void Main(string[] args)
    {

        //Regardless of the type, all events need to have an Event Title, Description, Date, Time, and Address.
        //Do not create a new "event" or parent only actual event type
        Address address01 = new Address("10 Sweet", "Pinckney", "MI", "USA");
        Lecture lecture01 = new Lecture("Screen Time Effects", "How screentime effects us", "01/05/24", "2:00 p.m.", address01, "Efrain Fajardo", "150");
        
        //Order order2 = new Order(customer2);
        //order2.displayShippingLabel();
        lecture01.standardDetails(); //listing different detail options for user
        Console.WriteLine();
        lecture01.fullDescription(); //note to not use full details methos here but insert full details within fullDescription so not repeating
        Console.WriteLine();
        lecture01.shortDesc();
        Console.WriteLine("\n");
        

        //Event event002 = new Event();
        Address address02 = new Address("3123 N. Gramer Rd.", "Webberville", "MI", "USA");
        Reception reception01 = new Reception("Thomas Wedding", "Drake and Haley Wedding", "06/22/24", "4:00 p.m.", address02);
        reception01.standardDetails();
        Console.WriteLine();
        reception01.fullDescription();
        Console.WriteLine();
        reception01.shortDesc();
        Console.WriteLine("\n");

        Address address03 = new Address("7147 Gawley Rd.", "Pinckney", "MI", "USA" );
        Outdoor outdoor01 = new Outdoor("Muller Graduation", "BYUI graduation for Melinda Muller", "04/12/25", "1:00 p.m.", address03, "Sunny and 80 degrees");
        outdoor01.standardDetails();
        Console.WriteLine();
        outdoor01.fullDescription();
        Console.WriteLine();
        outdoor01.shortDesc();
        Console.WriteLine("\n");
    }
}