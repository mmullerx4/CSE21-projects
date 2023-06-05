using System;

class Math : Assignments
{
    //private attributes(variables)
    private string _textBookSection;
    private string _problems;

    //constructor Note: constructors do not have a return type - It is left empty. How many arguments do you need?
    public Math(string problems, string textBookSection, string name, string topic) : base(name, topic)//require 2 arguments: a value for each attribute in math class
    {
        _textBookSection = textBookSection;
        _problems = problems;
    }

    //method 1 return summary of assignment for student name and topic. Meth
    //(Access Type) (Return Type) (Name( Parameters ))
    public void GetHomeworkList() //display the homework list with section number and problems "Section 7.3 Problems 8-19".
    {
        Console.WriteLine($"{_textBookSection} {_problems}"); //returns assignment summary with student name and topic
    }
    
}