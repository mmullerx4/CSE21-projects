using System;

class Program
{
    static void Main(string[] args)
    {
        Math math = new Math("Problems 8-19", "Section 7.3", "Roberto Rodrigues", "Fractions");
        Writing writing = new Writing("The Causes of World War II by Mary Waters", "Mary Waters", "European History");


        //scripture.scriptureDisplay();
        math.GetSummary(); //this gets the information from assignments and math
        math.GetHomeworkList();
        Console.WriteLine();
        writing.GetSummary();
        writing.GetWritingInformation();
        Console.WriteLine();

    }
}