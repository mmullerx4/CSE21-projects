using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string valueFromUser = Console.ReadLine();
        int num = int.Parse(valueFromUser);

        string letter = "";

        if (num >= 90)
        {
            letter = "A";
        }
        else if (num >= 80)
        {
            letter = "B";
        }
        else if (num >= 70)
        {
            letter = "C";
        }
        else if (num >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}.");

        if (num >= 70)
        {
            Console.Write($"Congratulations, you have passed the class!");
        }
        else
        {
            Console.Write($"Sorry, you have not passed the class.");
        }
    }
}