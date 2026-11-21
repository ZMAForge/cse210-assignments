class SimpleGoal : BaseGoal
{
    public SimpleGoal(string name, string description, int points, bool complete, string goaltype)
    : base (name, description, points, complete, goaltype)
    {  
    }
    public SimpleGoal():base("Simple Goal")
    {
    }

    public override int RecordEvent()
    {
        MarkComplete();
        return GetPoints();
    }
}