using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)//a special method- don't need declare public or private. Houses all.
    {
        Journal journal = new Journal(); // Journal type (class name), variable name, and then actual creation of a new journal instance.

        int choice = -1; //choice needs to exist before using it and set to negative one so not starting as one of options
        while (choice != 5)
        { 
            string menuOptions = "1)Write a new entry \n2)Display the journal \n3)Save the journal \n4)Load the journal \n5)Quit";
            Console.WriteLine(menuOptions);
            Console.WriteLine();
            choice = Convert.ToInt16(Console.ReadLine()); //converting to int because user is responding to string 

            if (choice == 1)
            {
                Entry entry = new Entry(); //class name then variable and creation of class & creating an entry
                
                entry.writeEntry(); //calling the writeEntry method from entry.cs with the new variable from above
                journal.entryCollection.Add(entry); //adding the entry to the journal using the list variable from journal
            }

            else if (choice == 2)
            { 
                journal.displayJournal();   //display to screen using the method from journal
            }

            else if (choice == 3)
            {
                journal.saveJournal(); //saving using the method from journal
                Console.WriteLine("You have saved your entry to your journal."); 
            }

            else if (choice == 4)
            {
                journal.loadJournal(); //loading the entry to the file using the method from journal
            }

            else
            {
               Console.Write("Thank you for journaling! Have a great day!"); 
            }

        }
        
    }
}