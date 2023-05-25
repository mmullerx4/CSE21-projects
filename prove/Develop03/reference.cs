using System;

class Reference
{
    private string _book;
    private string _chapter;
    private string _verse;

    private string _addVerse;

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

    //add the constructor
    
   public Reference()
   {
    _book = "1 Nephi";
    _chapter = "3";
    _verse = "7";
    _addVerse= "8";

   }

}