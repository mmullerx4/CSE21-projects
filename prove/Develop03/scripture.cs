using System;

class Scripture
{
    private Reference reference;
    private List<Word> _words = new List<Word>();

    // Create a constructor that takes in the string text
    // split the text into an array of words
    // loop throught the array and create a word objet for each word
    // add that object to the list.

    public Scripture(string text)  //constructor with a new parameter of text
    {

        string[] words = text.Split(' '); //creating a new variable words for text(scripture)
        foreach (string word in words)
        {
            Word wordObj = new Word(word);
            _words.Add(wordObj);
        }
    }
    public void scriptureDisplay()
    {
        // loop through the _words list and display each word by calling the display method in word
        foreach (word in _words)
        {
            //Word reference = new Reference("1 Nephi", "3", "7", "8");
            Word display1 = new Word();
        }
    }


    public string randomHide()
    {

        Random rnd = new Random();
        Word word1 = _words[rnd.Next(_words.Count)];
    

        //foreach(char c in _word);
        //Random r = new Random( );
        //index = r.Next( _word.Count ); //
        // string randomString = _word[ index ];
        //string[] mystrings = "apple|orange|mayo|fruit|dog".Split('|');
        //Random rnd = new Random();
        //string blah1 = mystrings[rnd.Next(mystrings.Length)];
        //string blah2 = mystrings[rnd.Next(mystrings.Length)];


    }

    // AllWordsHiddenStatus()
    // loop through the _words list, if there is a word that is still shown (_isHidden = false) then return false, otherwise return true is all are hidden

    public allHidden()
    {
        foreach (string word in words)
        {
            if (isHidden = false)
            {
                return false;
            }
            else {
                return true;
            }
        }
    }
}



