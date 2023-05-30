using System;

class Word{
   // Attributes (variables) (fields)
   private string _word;
   private bool _isHidden;

   // (Access Type) (Name(Paramters))
   //public Word(){}   //this would be the default constructor
   public Word(string word)
   {
      _word = word;
      _isHidden = false; //false because starts out as not hidden
   }

   // (Access Type) (Return Type) (Name(Paramters))
   public bool GetIsHidden() // Getter for _isHidden
   {
      return _isHidden; //return where ever called from
   }

   // Setter to set _isHidden to true
   public bool SetIsHidden()
   {
      _isHidden = true;
   }


   // DisplayWord
   // Check if the word is hidden
   // if it is hidden
   //    loop through te letters in the  word (foreach)
   //          print out "_"
   // else print out word
   public void DisplayWord()
   {
      if (_isHidden)
      {
         foreach (char letter in _word)
         {
            Console.Write("_");     
         }
      } else
      {
         Console.Write(_word);
      }
   }
}