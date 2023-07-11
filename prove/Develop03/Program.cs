using System;

class Program
{
    static void Main(string[] args)
    {
        string text = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no  commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them. | And it came to pass that when my father had heard these words he was exceedingly glad, for he knew that I had been blessed of the Lord.";
        //  v (*access type/Class Type) (Object Name) = new (Constructor Name(Parameters))
        Reference reference = new Reference("1 Nephi", "3", "7", "8");
        Scripture scripture = new Scripture(text);

        scripture.scriptureDisplay(); //display using the object above "scripture" and the method from scripture file
        reference.displayCombine(); //combine reference info using method from reference
        Console.WriteLine(); //empty line after scripture reference

        Console.WriteLine("Press enter to hide a word or type 'quit' to exit");
        string option = Console.ReadLine();
        if (option == "quit")
        {
            Environment.Exit(0); //C# code for exiting the program
        }
        // no need to state else - it will just continue until user enters quit

        //when hit enter the program will run through this loop
        while (true)
        {
            Console.Clear();
            int counter = 0;
            
            while (counter < 3)
            {
                if (scripture.randomHide()) // Same as (scripture.ramdonhide() == true)
                {
                    counter++; //increments by 1
                    if (scripture.allHidden())
                    {
                        break;
                    }
                }
            }

            scripture.scriptureDisplay(); //take the object above "scripture" and the method from the s
            reference.displayCombine();

            if (scripture.allHidden())
            {
                break;
            }

            Console.WriteLine("Press enter to hide a word or type 'quit' to exit");
            option = Console.ReadLine();

            if (option == "quit")
            {
                Environment.Exit(0); //C# code for exiting the program
            }
        }
    }
}