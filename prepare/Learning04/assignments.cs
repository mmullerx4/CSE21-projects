using System;

class Assignments
{
    private string _name;
    private string _topic; //"Fractions"

    //build constructor
    //access type, parameters
    public Assignments(string name, string topic)
    {
        _name = name;
        _topic = topic;
        
    }

    //build methods
    
    public void GetSummary()
    {
        // Interpolate a string $""
        //return $"{_name} - {_topic}";   //output looks like this "Samuel Benett - Multiplication"
        Console.WriteLine($"{_name} - {_topic}");
    }
}