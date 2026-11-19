class SimpleGoal : BaseGoal
{
    public SimpleGoal():base("Simple Goal")
    {
    }

    public SimpleGoal(string name, string description, int points, bool complete, string goaltype)
    : base (name, description, points, complete, goaltype)
    {
        
    }

    public override int RecordEvent()
    {
        return 0;
    }
}