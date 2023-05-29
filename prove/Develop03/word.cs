using System;

class Word{
   string _word;
   bool _isHidden = false;

   
   public string randomHide()
   {
      StringContent[] _word = "And|it|came|to|pass|".Split('|');
      Random rnd = new Random();
      string word1 = _word[rnd.Next(_word.Length)];

     //foreach(char c in _word);
     //Random r = new Random( );
     //index = r.Next( _word.Count ); //
     // string randomString = _word[ index ];
     //string[] mystrings = "apple|orange|mayo|fruit|dog".Split('|');
      //Random rnd = new Random();
      //string blah1 = mystrings[rnd.Next(mystrings.Length)];
      //string blah2 = mystrings[rnd.Next(mystrings.Length)];
      //string sentence = "here i am " + blah1 + " result chosen from mystring was " + blah2

   
     
      
   }

   public bool isHidden()
   {
      

   }
   
}