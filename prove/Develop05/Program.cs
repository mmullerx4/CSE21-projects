using System;
using System.IO;

class Program
{
    //Note that all information here cannot go in the goal file because this is where we create the goals
    //and then in the goal is where we use goals that are already created.
    //The goal file says this is what a goal does.
    //the managing of the goals is in program.cs ... this file orchestrates everything.
    static void Main(string[] args)
    {
        // note that inside the main or any function/method you do not use an access modifier (public, private...) with a local variable
        // sample code for the following...List<Entry> entryCollection = new List<Entry>();
        //List with type  variable  = new list with type
        //Breathing breathing = new Breathing(); ---list variation 
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

                
                //within a method so don't need class name
                int goalType = Convert.ToInt16(Console.ReadLine());
                Console.Write("What is the name of your goal? ");
                string _name = Console.ReadLine();
                Console.Write("What is a short description of your goal? ");
                string _description = Console.ReadLine();
                Console.Write("What will be the number of points for this goal? ");
                int _points = Convert.ToInt16(Console.ReadLine());

                if (goalType == 1)
                {
                    SimpleGoal simpleGoal = new SimpleGoal(_name,_description,_points,false); //naming the variable and calling the constructor all in one
                    //.entryCollection.Add(entry);
                    goals.Add(simpleGoal);
                }

                else if (goalType == 2)
                {
                    EternalGoal eternalGoal = new EternalGoal(_name,_description,_points);
                    goals.Add(eternalGoal);
                }

                else if (goalType == 3)
                {
                    Console.Write("What will be the total times to complete? ");
                    int _totalToComplete = Convert.ToInt16(Console.ReadLine());
                    Console.Write("What will be the number of bonus points when completed? ");
                    int _bonusPoints = Convert.ToInt16(Console.ReadLine());
                    CheckListGoal checkList = new CheckListGoal(_name,_description,_points,_bonusPoints,0,_totalToComplete);
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
                    {               //this will write to the file myFile.txt
                        //foreach(string goal in goals)
                        for(int i = 0; i < goals.Count; i++) //for each goal in the list
                        {
                            goals[i].GetStringRepresentation(); //creating the string
                            outputFile.WriteLine(goals[i].GetStringRepresentation()); //adding the string to the file
                        }      

                    }
                    
                    
                    break;

                case 4: //load
                    
                    //loadGoal.loadToFile(); ...if I was calling from another file
                    
                    string [] lines = System.IO.File.ReadAllLines("myFile.txt"); //calling my file as a string("")
                        // must have "using System.IO;" at the top of this file.
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(",");

                        string type = parts[0];
                        string name = parts[1];
                        string description = parts[2];
                        int points = Convert.ToInt16(parts[3]);
                        

                        switch (type)
                        {

                            case "SimpleGoal":
                            bool isComplete = Convert.ToBoolean(parts[4]);
                            SimpleGoal simpleGoal = new SimpleGoal(name,description,points,isComplete); //naming the variable and calling the constructor all in one
                            goals.Add(simpleGoal);
                            break;

                            case "EternalGoal":
                            EternalGoal eternalGoal = new EternalGoal(name,description,points); //naming the variable and calling the constructor all in one
                            goals.Add(eternalGoal);
                            break;

                            case "CheckListGoal":
                            int bonusPoints = Convert.ToInt16(parts[4]);
                            int numCompleted = Convert.ToInt16(parts[5]);
                            int totalToComplete = Convert.ToInt16(parts[6]);
                            
                            CheckListGoal checkListGoal = new CheckListGoal(name,description,points,bonusPoints,numCompleted,totalToComplete); //naming the variable and calling the constructor all in one
                            goals.Add(checkListGoal);
                            break;


                        }


                    }
    
                break;

                case 5: 
                    //simple change boolean to true and give points
                    //eternal give points
                    //checklist add 1 to complete, give points, and give bonus points if complete.
                    //record a goal
                    //Goal recordGoal = new Goal();
                    //recordGoal.recordEvent();
                    break;

                case 6:
                    break;


            }
        
        }
    }
}