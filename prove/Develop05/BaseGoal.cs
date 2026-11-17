using System.Dynamic;

class BaseGoal
{
    private string _name;
    public BaseGoal()
    {
        SetName();
    }

    private void SetName()
    {
        Console.WriteLine("What is the name of your goal: ");
        _name = Console.ReadLine();
    }

    public virtual string GetConsoleString()
    {
        return $"[ ] Goal Name: {_name}";
    }
}