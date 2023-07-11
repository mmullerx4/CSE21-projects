using System;

class Reflection : Activity
{
    private List<string> _prompts = new List<string>() //creating the variable prompts in list format
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    }; //";" ends the values in the list

    private Random rand = new Random(); //using the "Random" building class for both variables

    private List<string> _question = new List<string> //creating the variable question in list format
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    }; //";" ends the values in the list

   
    public Reflection()  //constructor.. no parameters needed because values are entered on line 31 & 32
    {
       _activityName = "reflection";
       _activityDescription = "reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    //This file needs to:
    //random prompt
    //random question loop with pause for several seconds for answer

    public void randomPrompt()
    {
        getStartMsg(); //getting starting message from 
        //my list type is a string. And it is a random string from the list
        string promptObj = _prompts[rand.Next(_prompts.Count)]; //pulling a random prompt with variable from line 5
        Console.WriteLine(promptObj); //then displaying that prompt with new variable "prompObj"
        getPauseCounter(15); //15 second countdown before moving on
        randomQuestion(); //calling method from below to keep moving forward in program
    }

        public void randomQuestion() //note this method is running within the method above
        {
            DateTime futureTime = getDuration(_duration);

            while (DateTime.Now <= futureTime)
            {
                 //my list type is a string. And it is a random string from the list
                string questionObj = _question[rand.Next(_question.Count)]; //random question with new variable
                Console.WriteLine(questionObj); //display the random question to user
                getPauseSpinner(15); //spin for several seconds  
            }
            getEndMsg(); //call method from activity 
        }
}

