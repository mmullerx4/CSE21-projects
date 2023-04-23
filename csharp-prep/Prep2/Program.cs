using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string valueFromUser = Console.ReadLine();
        int num = int.Parse(valueFromUser);

        if (num >= 90)
        {
            Console.WriteLine("Congratulations, your grade is an A");
        }
        else if (num >= 80)
        {
            Console.WriteLine("Congratulations, your grade is a B");
        }
        else if (num >= 70)
        {
            Console.WriteLine("Congratulations, your grade is a c");
        }
        else if (num >= 60)
        {
            Console.WriteLine("Sorry, your grade is a D, you have not passed the class");
        }
        else
        {
            Console.WriteLine("Congratulations, your grade is a B");
        }
    }
}