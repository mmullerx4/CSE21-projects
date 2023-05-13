using System;

class Entry
{
    string randomPrompt;
    string UserResponse;
    int entryDate;
    public string writeEntry() {
    //Getting a random value with this code example from stack overflow
    //int value1 = 3;
    //int anotherValue = 5;
    //int value2 = 1;

    //int[] selectableInts = new int[3] { value1, anotherValue, value2 };

    //Random rand = new Random();

    //int randomValue = selectableInts[rand.Next(0, selectableInts.Length)];

    string[] randomPrompt = new string[5] { 
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What did I learn today?",
        "What would I have done better today?"
        };

    Random rand = new Random();
    string randomValue = randomPrompt[rand.Next(0, randomPrompt.Length)];
    Console.WriteLine(randomPrompt);

    string userResponse = Console.ReadLine();

    int entryDate = 
    }

    public void saveEntry();
    
}