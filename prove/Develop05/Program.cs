using System;

class Program
{
    static void Main(string[] args)
    {
        while(true)
        {
            Console.WriteLine("Menu options:");
            Console.Write("1. Create New Goal \n 2. List Goals \n 3. Save Goals \n 4. Load Goals \n 5. Record Event \n 6. Quit \n");
            Console.WriteLine("Select a choice from the menu: ");

            int menuChoice = 1;
            switch (menuChoice)
            {
                case 1:
                //calling the method is this format "breathing.alternateBreath();"
                Console.WriteLine("The type of goals are: ");
                Console.Write("1. Simple goal \n 2. Eternal goal \n 3. Check List goal \n");

                //Breathing breathing = new Breathing();
                int goalType = Convert.ToInt16(Console.ReadLine());

                if (goalType == 1)
                {
                    SimpleGoal simpleGoal = new SimpleGoal(); //naming the variable and calling the constructor all in one
                }

                else if (goalType == 2)
                {
                    EternalGoal eternalGoal = new EternalGoal();
                }

                else if (goalType == 3)
                {
                    CheckListGoal checkList = new CheckListGoal();
                }
                
                break;
                case 3:
                ;
                break;

                case 4:
                SimpleGoal  = new SimpleGoal();
                break;

                case 5:
                SimpleGoal  = new SimpleGoal();
                break;

                case 6:
                SimpleGoal  = new SimpleGoal();
                break;


            }
             case 1:
                SimpleGoal simpleGoal = new SimpleGoal();
                break;

                case 2:
                EternalGoal eternalGoal = new EternalGoal();
                break;

                case 3:
                SimpleGoal simpleGoal = new SimpleGoal();
                break;

                case 4:
                SimpleGoal simpleGoal = new SimpleGoal();
                break;

                case 5:
                SimpleGoal simpleGoal = new SimpleGoal();
                break;

                case 6:
                SimpleGoal simpleGoal = new SimpleGoal();
                break;

        
        }
    }
}