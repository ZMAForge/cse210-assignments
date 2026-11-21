class EternalGoal : BaseGoal
{
    int _numberOfCompletions;

    public EternalGoal(string name, string description, int points, bool complete, string goaltype, int completions)
    :base (name, description, points, complete, goaltype)
    {
        _numberOfCompletions = completions;
    }
    public EternalGoal():base("Eternal Goal")
    {}

    public override int RecordEvent()
    {
        _numberOfCompletions ++;
        return GetPoints();
    }

    public override string GetConsoleString()
    {
        return $"[ ] Goal Name: {getName()}, Desc: {GetDescription()}, Points: {GetPoints()} \n Number of Completions: {_numberOfCompletions}";
    }
}