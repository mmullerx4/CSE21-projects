using System;

class Program
{
    static void Main(string[] args)
    {
        // note that inside the main or any function you do not use a type with a local variable
        // example...List<Entry> entryCollection = new List<Entry>();
                  //List with type  varialbe  = new list with type 
        List<Goal> goals = new List<Goal>();
        //goals = goals in the list

        int menuChoice = 1;

        while(menuChoice != 6) 
        {
            Console.WriteLine("Menu options:");
            Console.Write("1. Create New Goal \n 2. List Goals \n 3. Save Goals \n 4. Load Goals \n 5. Record Event \n 6. Quit \n");
            Console.WriteLine("Select a choice from the menu: ");
            menuChoice = Convert.ToInt16(Console.ReadLine());

            switch (menuChoice)
            {
                case 1: //creating a goal
                
                Console.WriteLine("The type of goals are: ");
                Console.Write("1. Simple goal \n 2. Eternal goal \n 3. Check List goal \n");

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
                    for (int i =0; i < goals.Count; i++)
                    {
                        
                        goals[i].displayGoals(i + 1);
                        
                    }
                    break;

                case 3: //save
                    saveGoal.saveToFile();
                    break;

                case 4: //load
                    
                    loadGoal.loadToFile();
                break;

                case 5: //record a goal
                    Goal recordGoal = new Goal();
                    recordGoal.recordEvent();
                    break;

                case 6:
                    break;


            }
        
        }
    }
}