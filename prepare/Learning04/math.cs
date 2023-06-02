using System;

class Math : Assignments
{
    //private attributes(variables)
    private string _textBookSection;
    private string _problems;


    //constructor Note: constructors do not have a return type - It is left empty. How many arguments do you need?
    public Math(string _problems, string _textBookSection, string _name, string _topic) : base(_name, _topic)//require 2 arguments: a value for each attribute in math class
    {
        this._textBookSection = _textBookSection;
        this._problems = _problems;
    }

    //method 1 return summary of assignment for student name and topic. Meth
    //(Access Type) (Return Type) (Name( Parameters ))
    public string GetHomeworkList() //display the homework list with section number and problems "Section 7.3 Problems 8-19".
    {
        return //returns assignment summary with student name and topic
    }

    





}