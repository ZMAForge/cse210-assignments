class Goals
{
    private List<BaseGoal> _goals = new List<BaseGoal>();
    private string _filename;
    int total_score;

    public Goals()
    {
        Console.Write("What file should goals be read from and written to?\n  >");
        _filename = Console.ReadLine();
        total_score = 0;
    }

    public void AddGoal(BaseGoal goal)
    {
        _goals.Add(goal);
    }

    public void SaveGoals()
    {
        using (StreamWriter output = new StreamWriter(_filename))
        {
            output.WriteLine(total_score);

            foreach (BaseGoal goal in _goals)
            {
                if (goal is SimpleGoal)
                {
                    output.WriteLine(
                        $"SimpleGoal|{goal.GetName()}|{goal.GetDescription()}|{goal.GetPoints()}|{goal.GetComplete()}"
                    );
                }
                else if (goal is EternalGoal)
                {
                    output.WriteLine(
                        $"EternalGoal|{goal.GetName()}|{goal.GetDescription()}|{goal.GetPoints()}|{goal.GetComplete()}|{goal.GetCount()}"
                    );
                }
                else if (goal is CheckListGoal checklist)
                {
                    output.WriteLine(
                        $"CheckListGoal|{goal.GetName()}|{goal.GetDescription()}|{goal.GetPoints()}|{goal.GetComplete()}|{goal.GetCount()}|{checklist.GetMaxGoal()}"
                    );
                }
            }
        }
    }

    public void LoadGoals()
    {
        _goals.Clear();

        string[] lines = File.ReadAllLines(_filename);

        total_score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');

            switch (parts[0])
            {
                case "SimpleGoal":
                    _goals.Add(new SimpleGoal(
                        parts[1],
                        parts[2],
                        int.Parse(parts[3]),
                        bool.Parse(parts[4]),
                        "Simple Goal"
                    ));
                    break;

                case "EternalGoal":
                    _goals.Add(new EternalGoal(
                        parts[1],
                        parts[2],
                        int.Parse(parts[3]),
                        bool.Parse(parts[4]),
                        "Eternal Goal",
                        int.Parse(parts[5])
                    ));
                    break;

                case "CheckListGoal":
                    _goals.Add(new CheckListGoal(
                        parts[1],
                        parts[2],
                        int.Parse(parts[3]),
                        bool.Parse(parts[4]),
                        "Check List Goal",
                        int.Parse(parts[5]),
                        int.Parse(parts[6])
                    ));
                    break;
            }
        }
    }
    public void RecordEvent()
    {
        int count = 1;
        foreach(BaseGoal goal in _goals)
        {
            Console.WriteLine($"{count}. {goal.GetName()}");
        }
        Console.Write("\n Which would you like to add a completion for? Enter the number: ");
        int spot = int.Parse(Console.ReadLine());
        _goals[spot-1].RecordEvent();
    }

    public void DisplayGoals()
    {
        foreach(BaseGoal goal in _goals)
        {
            Console.WriteLine(goal.GetConsoleString());
        }
    }

    public void DisplayScore()
    {
        foreach(BaseGoal goal in _goals)
        {
            // TODO HERE
            if(goal is SimpleGoal)
            {
                total_score = total_score + goal.GetPoints();
            }
            else if(goal is EternalGoal)
            {
                total_score = total_score + (goal.GetPoints()* goal.GetCount());
            }
            else if(goal is CheckListGoal)
            {
                total_score = total_score + (goal.GetPoints()*goal.GetCount());
            }
            else
            {
                total_score = total_score + 0;
            }
        }
        Console.WriteLine(total_score);
    }
}