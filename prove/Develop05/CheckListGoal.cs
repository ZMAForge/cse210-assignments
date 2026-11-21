class CheckListGoal: BaseGoal
{
    int _numberOfCompletions;
    int _maxGoal;
    int _bonuspoints;
    public CheckListGoal(string name, string description, int points, 
    bool complete, string goaltype, int completions, int maxgoal)
    :base(name, description, points, complete, goaltype)
    {
        _numberOfCompletions = completions;
        _maxGoal = maxgoal;
        _bonuspoints = points*2;
    }

    public CheckListGoal():base("Check List Goal")
    {
        _numberOfCompletions = 0;
        _bonuspoints = GetPoints()*2;
        SetMaxGoal();
    }

    private void SetMaxGoal()
    {
        Console.Write("\nHow many times do you want to complete this goal?\n>  ");
        _maxGoal= int.Parse(Console.ReadLine());
    }

    public override int RecordEvent()
    {
        _numberOfCompletions++;
        if(_numberOfCompletions < _maxGoal)
        {
            return GetPoints();
        }
        else if(_numberOfCompletions == _maxGoal)
        {
            MarkComplete();
            return _bonuspoints;
        }
        else return 0;
    }

    public override string GetConsoleString()
    {
        string completeString = " ";
        if (GetComplete())
        {
            completeString = "X";
        }
        return $"[{completeString}] Goal Name: {GetName()}, Desc: {GetDescription()}, Points: {GetPoints()}\n Completions: {_numberOfCompletions}/{_maxGoal}";
    }
}