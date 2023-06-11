using System;

class Program
{   
    //minimal information here
    static void Main(string[] args)
    {
        while(true)
        {
            Console.Write("1. Start breathing activity\n 2. Start reflecting activity\n 3. Start Listing activity\n 4. Quit");
            Console.Write("Select a choice from the menu: ");

            int menuSelection = int.Parse(Console.ReadLine()); //capturing the user's choice


            if (menuSelection == 1)
            {
                Breathing breathing = new Breathing(); //creating a new object to use to call the method with
                breathing.alternateBreath(); //calling the method from breathing.cs
            }

            else if (menuSelection == 2)
            {
                Reflection reflection = new Reflection();
                reflection.randomPrompt();
            }
            else if (menuSelection == 3)
            {
                Listing listing = new Listing();
                listing.randomPrompt();
            }

            else
            {
                break; //when the user chooses 4 or anything else the loop breaks or quits
            }

        }
    }
     
}