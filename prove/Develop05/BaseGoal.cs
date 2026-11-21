using System.ComponentModel;
using System.Dynamic;

abstract class BaseGoal
{
    private string _name;
    private string _desc;
    private int _score;
    private bool _complete;
    private string _goalType;


    public BaseGoal(string name, string description, int points, bool complete, string goaltype)
    {
        // This will be used when reading from the file (?)
        _name = name;
        _desc = description;
        _score = points;
        _complete = complete;
        _goalType = goaltype;
    }
    public BaseGoal(string goaltype)
    {
        SetName();
        SetDescription();
        SetPoints();
        _complete = false;
        _goalType = goaltype;
    }

    private void SetName()
    {
        Console.WriteLine("What is the name of your goal: ");
        _name = Console.ReadLine();
    }

    public string GetName()
    {
        return _name;
    }

    private void SetDescription()
    {
        Console.WriteLine($"What is the description of {_name} goal: ");
        _desc = Console.ReadLine();
    }

    public string GetDescription()
    {
        return _desc;
    }
    private void SetPoints()
    {
        Console.WriteLine($"What is point value of {_name} goal: ");
        _score = int.Parse(Console.ReadLine());
    }

    public int GetPoints()
    {
        return _score;
    }

    public bool GetComplete()
    {
        return _complete;
    }

    public virtual string GetConsoleString()
    {
        string completeString = " ";
        if (_complete)
        {
            completeString = "X";
        }
        return $"[{completeString}] {_goalType} Goal Name: {_name}, Desc: {_desc}, Points: {_score}";
    }

    public int MarkComplete()
    {
        _complete = true;
        return _score;
    }

    public abstract int RecordEvent();
}