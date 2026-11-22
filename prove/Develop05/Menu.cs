class Menu
{
    Goals myGoals = new Goals();
    private void GoalCreateMenu()
    {
        Console.WriteLine("Which Goal would you like to create?\n  1. A simple goal");
        Console.WriteLine("  2. A checklist goal\n  3. An eternal goal");
        Console.Write("\nEnter your choice:   > ");
        int response = int.Parse(Console.ReadLine());

        switch(response)
        {
            case 1:
                SimpleGoal mySimpleGoal = new SimpleGoal();
                myGoals.AddGoal(mySimpleGoal);
                break;
            case 2:
                CheckListGoal myCheckListGoal = new CheckListGoal();
                myGoals.AddGoal(myCheckListGoal);
                break;
            case 3:
                EternalGoal myEternalGoal = new EternalGoal();
                myGoals.AddGoal(myEternalGoal);
                break;
        }
    }
    public void DisplayMenu()
    {
        int response = 0;
        while(response != 4)
        {
            Console.WriteLine($"Welcome to your goal tracker! Your current score is {myGoals.DisplayScore}");
            Console.WriteLine("Menu Options:\n  1. Create Goals");
            Console.WriteLine("  2. Record Completion\n  3. Save Goals");
            Console.WriteLine("  4. Load Goals\n  5. Quit\nSelect a choice from the menu: ");
            Console.Write("\n  >  ");
            response = int.Parse(Console.ReadLine());
            
            switch (response)
            {
                case 1:
                    GoalCreateMenu();
                    break;
                case 2:
                    myGoals.RecordEvent();
                    break;
                case 3:
                    myGoals.SaveGoals();
                    break;
                case 4:
                    myGoals.LoadGoals();
                    break;
                case 5:
                    break;
                default:
                    break;
            }
        }
        Console.WriteLine("Thank you for practicing mindfulness! Have a good day!");
    }
}