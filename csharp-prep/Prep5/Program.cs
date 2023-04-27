using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int numSquare = SquareNumber(userNumber);

        DisplayResult(userName, numSquare);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int number)
    {
        Console.Write("Enter an integer: ");
        int numSquare = number * number;
        return numSquare;
    }

    static void DisplayResult(string name, int numSquare)
    {
        Console.WriteLine($"Your name is: {name} and Your number squared is: {numSquare}");
    }
}