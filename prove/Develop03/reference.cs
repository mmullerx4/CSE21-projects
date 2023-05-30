using System;

class Reference
{
    private string _book;
    private string _chapter;
    private string _verse;

    private string _addVerse;


//add constructors to set up the class to be ready

//create constructor with three parameters
  public Reference(string book, string chapter, string verse)
   {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _addVerse = "";
   }
    
    //the same constructor with four parameters
   public Reference(string book, string chapter, string verse, string addVerse)
   {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _addVerse= addVerse;
   }


//Then add methods
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