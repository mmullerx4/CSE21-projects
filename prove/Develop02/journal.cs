using System;
using System.IO;

class Journal
{
    string journalFileName; //declaring variable
    string [] lines = System.IO.File.ReadAllLines(journalFileName);
    List<Entry> entryCollection; //declaring list
   public List<Entry> displayJournal() //creating a method (an action)
   { 
        
        foreach (string line in lines) //for each line display on screen
        {
            string[] parts = line.Split(",");

            //string firstName = parts[0];
            //string lastName = parts[1];
        }
        
        //return Entry;

   }

   public string saveJournal()
   {
       string fileName = "myFile.txt";
       using (StreamWriter outputFile = new StreamWriter(filename))
       {
        outputFile.WriteLine("This will be the first line in the file.");

       }


   }
   

   public string loadJournal() //just loading
   {
        List <Entry> Entry = new List<Entry>(); //adding a new list entry to a list of entries.
        string Console.Write("What is the name of your file? ");
        string filename = Console.ReadLine(); // storing user's input in "filename" variable 
        string [] lines = System.IO.ReadAllLines(filename); //storing all lines in "lines" array. IO is Input/Output
                        // must have "using System.IO;" at the top of this file.

   }

   
}