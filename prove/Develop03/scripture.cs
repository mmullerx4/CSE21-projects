using System;

class Scripture
{
    private Reference reference; //need to use this attribute for scripture so use with type same as file name
    private List<Word> _words = new List<Word>(); //^same...using the class Word as my type (file name) in <>
    private Random rnd = new Random(); //declaring the variable "rnd" and creates a new instance(or instantiate it) for Random.

    // Create a constructor that takes in the string text
    // split the text into an array of words
    // loop through the array and create a word object for each word
    // add that object to the list.

    public Scripture(string text)  //constructor with a new parameter of text then set values for words
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
    
            if (wordObj.GetWord() == "|") //note this method from word file using new variable from line 27
            {
                Console.WriteLine("\n"); //adds two empty lines
            }
            else   //if not "|"
                wordObj.DisplayWord(); //using method from word with variable from line 20.
            Console.Write(" ");
        }
    }

    public bool randomHide() //when there is a return it needs a type and not a void
    {

        //              ListVariableName[      index            ]   brackets mean index 
        //                  rnd is using   random generator
        //                         .Next generates a random number between 0 and the max value we pass in. In this case the max value is the size of the list of words (_words.Count)        
        Word wordObj = _words[rnd.Next(_words.Count)]; //declaring the new wordObj for this method for in the list _words with a random index number.
        if (wordObj.GetIsHidden() == false) //using method from word and variable form line 48 to check if not hidden
        {
            wordObj.SetIsHidden();  //call method from to hide the word and then return as true
            return true;
        }

        return false; // If we did not hide a word we will return false      
    }

    // AllWordsHiddenStatus()
    // loop through the _words list, if there is a word that is still shown (_isHidden = false) then return false, otherwise return true is all are hidden

    public bool allHidden() //creating a new method with type bool for the boolean and checking if hidden.
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



