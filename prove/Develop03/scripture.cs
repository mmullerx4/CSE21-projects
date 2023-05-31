using System;

class Scripture
{
    private Reference reference;
    private List<Word> _words = new List<Word>(); //using the class Word as my type in <>

    private Random rnd = new Random(); //declaring the variable "rnd" that uses the new function for Random or creates a new instance(or instantiate it) for Random.

    // Create a constructor that takes in the string text
    // split the text into an array of words
    // loop through the array and create a word object for each word
    // add that object to the list.

    public Scripture(string text)  //constructor with a new parameter of text
    {

        string[] words = text.Split(' '); //creating a new variable words for text(scripture)
        foreach (string word in words) //creating the new variable word with type string
        {
            Word wordObj = new Word(word); //declaring Word class with a new object named wordObj with a new word instance
            _words.Add(wordObj); //then adding wordObj to the word list
        }
    }
    public void scriptureDisplay() //creating a method for displaying the scripture
    {
        // loop through the _words list and display each word by calling the display method in the word class
        foreach (Word wordObj in _words) //using the class name as my type, "wordObj" is a new attribute, for the list _words
        {
            //Word reference = new Reference("1 Nephi", "3", "7", "8");
    
            if (wordObj.GetWord() == "|")
            {
                Console.WriteLine("\n"); //adds two empty lines
            }
            else   //if not "|"
                wordObj.DisplayWord(); //taking declared attribute and calling the method from the class Words.
            Console.Write(" ");
        }
    }


    public bool randomHide() //is void because is just setting to true and no return
    {

        //              List[      index            ]    
        //                         random generator
        //                         .Next generats a random number between 0 and the max value we pass in. In this case the max value is the size of the list of words (_words.Count)        
        Word wordObj = _words[rnd.Next(_words.Count)]; //declaring the new wordObj for this method for in the list _words with a random index number.
        if (wordObj.GetIsHidden() == false) //check if not hidden
        {
            wordObj.SetIsHidden();  //call the SetIsHidden method to hide the word and then return as true
            return true;
        }

        return false; // If we did not hide a word we will return false
        
        
    }

    // AllWordsHiddenStatus()
    // loop through the _words list, if there is a word that is still shown (_isHidden = false) then return false, otherwise return true is all are hidden

    public bool allHidden() //creating a new method with no return type (void) for the boolean and checking if hidden.
    {
        foreach (Word wordObj in _words) //creating the variable wordObj (within this method) in _words list for the loop
        {
            if (wordObj.GetIsHidden() == false) //taking my new variable "wordObj" and calling the GetIsHidden() from the word class.
            {
                return false;
            }
        }
        return true; // returns true unless false it goes through the if statement.
    }
}



