using System.Dynamic;

class BaseGoal
{
    private string _name;
    private string _desc;
    private int _score;
    public BaseGoal()
    {
        SetName();
        SetDescription();
        SetPoints();
    }

    private void SetName()
    {
        Console.WriteLine("What is the name of your goal: ");
        _name = Console.ReadLine();
    }

    private void SetDescription()
    {
        Console.WriteLine($"What is the description of {_name} goal: ");
        _desc = Console.ReadLine();
    }
    private void SetPoints()
    {
        Console.WriteLine($"What is point value of {_name} goal: ");
        _score = int.Parse(Console.ReadLine());
    }
    public virtual string GetConsoleString()
    {
        return $"[ ] Goal Name: {_name}, Desc: {_desc}, Points: {_score}";
    }
}