using System;

class Program
{
    static void Main(string[] args)
    {
        // note that inside the main or any function/method you do not use an access modifier (public, private...) with a local variable
        // sample code for the following...List<Entry> entryCollection = new List<Entry>();
        //List with type  variable  = new list with type 
        List<Goal> goals = new List<Goal>();
        //goals = goals in the list

        int menuChoice = 1;

        while(menuChoice != 6) 
        {
            Console.WriteLine("Menu options:");
            Console.Write("\n 1. Create New Goal \n 2. List Goals \n 3. Save Goals \n 4. Load Goals \n 5. Record Event \n 6. Quit \n");
            Console.Write("Select a choice from the menu: ");
            Console.WriteLine();
            menuChoice = Convert.ToInt16(Console.ReadLine());

            switch (menuChoice)
            {
                case 1: //creating a goal
                
                Console.WriteLine("The type of goals are: ");
                Console.Write("\n 1. Simple goal \n 2. Eternal goal \n 3. Check List goal \n");
                Console.Write("What type of goal would you like to create? ");

                //Breathing breathing = new Breathing();
                int goalType = Convert.ToInt16(Console.ReadLine());

                if (goalType == 1)
                {
                    SimpleGoal simpleGoal = new SimpleGoal(); //naming the variable and calling the constructor all in one
                    //.entryCollection.Add(entry);
                    goals.Add(simpleGoal);
                }

                else if (goalType == 2)
                {
                    EternalGoal eternalGoal = new EternalGoal();
                    goals.Add(eternalGoal);
                }

                else if (goalType == 3)
                {
                    CheckListGoal checkList = new CheckListGoal();
                    goals.Add(checkList);
                }
                break;

                case 2: //displaying a goal
                //can do a foreach loop or a for loop which is simpifying
                    //int i = 1; //first number displayed
                    //foreach(Goal goal in goals)
                    //{
                        //Console.Write(i);
                        //goal.displayGoals();
                        //i++;
                    //}
                    for (int i =0; i < goals.Count; i++) //less than the count of the list
                    {
                        
                        goals[i].displayGoals(i + 1); //displaying the goals but adding 1 to my "i" variable
                        
                    }
                    break;

                case 3: //save
                    //saveGoal.saveToFile();
                    Console.WriteLine("Your goal is saved.");
                    string fileName = "myFile.txt"; //local variable name of file
                    using (StreamWriter outputFile = new StreamWriter(fileName))//StreamWriter creates a file
                    {
                        //foreach(string goal in goals)
                        for(int i = 0; i < goals.Count; i++) //for each goal in the list
                        {
                            goals[i].saveToFile();
                        }
                        outputFile.WriteLine(_totalPoints); //change to a getter
                        outputFile.WriteLine(goals.GetStringRepresentation()); //the "()" is what actually calls the function/method

                    }
                    
                    
                    break;

                case 4: //load
                    
                    //loadGoal.loadToFile();
                break;

                case 5: //record a goal
                    //Goal recordGoal = new Goal();
                    //recordGoal.recordEvent();
                    break;

                case 6:
                    break;


            }
        
        }
    }
}