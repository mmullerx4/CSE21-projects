using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)//a special method- don't need declare public or private. Houses all.
    {
        Journal journal = new Journal(); // Journal type and class name, variable name, and then actual creation of class Journal.

        int choice = -1; //choice needs to exist before using it
        while (choice != 5)
        { 
            string menuOptions = "1)Write a new entry \n2)Display the journal \n3)Save the journal \n4)Load the journal \n5)Quit";
            Console.WriteLine(menuOptions);
            Console.WriteLine();
            choice = Convert.ToInt16(Console.ReadLine()); //converting to int because user is responding to string 

            if (choice == 1)
            {
                Entry entry = new Entry(); //class name then variable and creation of class & creating an entry
                
                entry.writeEntry(); //calling the writeEntry method from entry.cs
                journal.entryCollection.Add(entry); //adding the entry to the journal
                

            }

            else if (choice == 2)
            {
                

                journal.displayJournal(); 
               
                
            }

            else if (choice == 3)
            {
                journal.saveJournal();
                Console.WriteLine("You have saved your entry to your journal.");
            }

            else if (choice == 4)
            {
                journal.loadJournal();
            }

            else
            {
               Console.Write("Thank you for journaling! Have a great day!"); 
            }

        }
    //How does this apply? This probably goes in the journal file
        
    }
}