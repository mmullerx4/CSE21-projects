using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
              
        int choice = -1; //choice needs to exist before using it
        while (choice != 5)
        { 
            string menuOptions = "1)Write a new entry \n2)Display the journal \n3)Save the journal \n4)Load the journal \n5)Quit";
            Console.WriteLine(menuOptions);
            choice = Convert.ToInt16(Console.ReadLine()); //converting to int because user is responding to string 

            if (choice == 1)
            {
                Entry entry = new Entry(); //class name then variable and creation of class & creating an entry
                
                entry.writeEntry(); //calling the writeEntry method from entry.cs

            }

            else if (choice == 2)
            {
                Journal journal = new Journal(); // class name, variable name and creation of class and Journal

                journal.displayJournal();     
                
            }

            else if (choice == 3)
            {
                Journal.saveJournal();
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