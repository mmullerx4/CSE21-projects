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
                


            }

            else if (choice == 2)
            {
                
            }

            else if (choice == 3)
            {
                
            }

            else if (choice == 4)
            {
                
            }

            else
            {
                
            }

        }
    //How does this apply? This probably goes in the journal file
        Public static List<Entry> ReadFromFile()
        {
            List <Entry> Entry = new List<Entry>();
            string filename = "Entry.csv";
            string [] lines = System.IO.ReadAllLines(filename);

            foreach (string line in lines)
            {
                Console.Write(line);
            }
            
            return Entry;
        }
    }
}