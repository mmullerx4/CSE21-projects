using System;

class Reference
{
    private string _book;
    private string _chapter;
    private string _verse;
    private string _addVerse;


//add constructors to set up the class to be ready

//create constructor with three parameters
  public Reference(string book, string chapter, string verse) //not addverse because setting a blank no value below
   {                                                          //for no second verse
        _book = book; //setting up to be used (values plugged in) in program.cs
        _chapter = chapter;
        _verse = verse;
        _addVerse = "";
   }
    
    //the same constructor with four parameters
   public Reference(string book, string chapter, string verse, string addVerse) //second option for if second verse 
   {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _addVerse= addVerse;
   }


//add method for combining reference info (variables)
    public void displayCombine()
    {
        
        if (_addVerse != "") 
        {
            Console.WriteLine($"{_book} {_chapter}: {_verse}-{_addVerse}");
        }
        else
        {
            Console.WriteLine($"{_book} {_chapter}:{_verse}");
        }
    } 
}