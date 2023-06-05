using System;
class Writing : Assignments
{
    //private attributes(variables)
    private string _title;

    //constructor
    public Writing(string title, string name, string topic) : base (name, topic)//requires a value for each attribute in this class (title, topic) ie. "European History, The Causes of World WarII".
    {
        _title = title;    
    }

    //method 1 return summary of assignment for student name and topic
    public void GetWritingInformation() //get the writing information with title and student's name ie. "The Causes of World War II by Mary Waters".
    {
        Console.WriteLine($"{_title}");
    }

}