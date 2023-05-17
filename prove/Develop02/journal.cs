using System;
using System.IO;

class Journal //class is a blueprint on how to create Journal
{
    string journalFileName; //declaring variable
    
    public List<Entry> entryCollection = new List<Entry>();//declaring list and initializing with the " = ????" ". ()" for a new class
    public void displayJournal() //creating a method(an action) from List<Entry> but no return
   { 
        
        foreach (Entry entry in entryCollection) //In class Entry for each line(entry) in entryCollection
        {    
            Console.WriteLine(entry._entryDate); //displaying date, prompt, response
            Console.WriteLine(entry._randomValue);
            Console.WriteLine(entry._userResponse);   
        }         
   }

   public void saveJournal()
   {
       string fileName = "myFile.txt";
       using (StreamWriter outputFile = new StreamWriter(fileName))//StreamWriter creates a file
       {
        foreach (Entry entry in entryCollection){   
            outputFile.WriteLine($"{entry._entryDate}|{entry._randomValue}|{entry._userResponse}"); //writing these to the file
            outputFile.WriteLine();
            outputFile.WriteLine();  
        }  

       }

   }
   

   public void loadJournal() //just loading
   {
        List <Entry> Entry = new List<Entry>(); //adding a new list entry to a list of entries.
        Console.Write("What is the name of your file? ");
        string filename = Console.ReadLine(); // storing user's input in "filename" variable 
        string [] lines = System.IO.File.ReadAllLines(filename); //storing all lines in "lines" array. IO is Input/Output
                        // must have "using System.IO;" at the top of this file.
   }
   
}