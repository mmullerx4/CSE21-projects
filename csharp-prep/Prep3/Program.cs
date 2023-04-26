/* Melinda Muller
Purpose: Practice C# with guess the magic number
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        //Console.WriteLine("Guess the Magic Number");

            int guess = -1;

            while (guess != magicNumber)
            {    
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (guess < magicNumber)  
                {
                    Console.WriteLine("Guess higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Guess lower");
                }    
                else 
                {
                     Console.WriteLine("You guessed right!");
                }
                   
                //guessCount += 1
                
            
            //Console.WriteLine("Your total guess count was: {guessCount} ");

            //playAgain = Console.Write("Would you like to play again (yes/no)? ");
            
            }        
    }
}