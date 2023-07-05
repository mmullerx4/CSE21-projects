using System;

class Comment{
    public string _personName;
    public string _textComment;


    public string textComment()
    {
        return _textComment;    
    }

    public string Display()
    {
        return $"Name: {_personName}";
    }
            
}