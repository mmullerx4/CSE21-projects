using System;

class Reflection : Activity
{
    private List<string> _prompts = new List<string>() //creating the variable prompts in list format
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless"
    };
    private Random rand = new Random(); //using the "Random" building class for both variables
    private List<string> _question = new List<string>() //creating the variable prompts in list format
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience",
        "How can you keep this experience in mind in the future?"
    };

    //constructor
    public Reflection(string startingMsg, string endingMsg) : base(startingMsg, endingMsg)
    {
       _activityName = "reflection";
       _activityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

    }


    //This file needs to:
    //random prompt
    //random question loop with pause for several seconds for answer

    public void randomPrompt()
    {
        getStartMsg();
        //my list type is a string. And it is a random string from the list
        string promptObj = _prompts[rand.Next(_prompts.Count)]; //pulling a random prompt
        Console.WriteLine(promptObj); //then displaying that promp
    }

        public void randomQuestion()
        {
            
            DateTime futureTime = getDuration(_duration);

            while (DateTime.Now <= futureTime)
            {
                 //my list type is a string. And it is a random string from the list
                string questionObj = _question[rand.Next(_question.Count)];
                Console.WriteLine(questionObj);
                getPauseSpinner();
                
            }
            getEndMsg();
           
        }

}

