using System.Dynamic;

class MathAssignment: Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string name, string topic, string textSect, string problems):base(name, topic)
    {
        _textbookSection = textSect;
        _problems = problems;
    }

    public string GetHomeWorkList()
    {
        return $"{_textbookSection} {_problems}";
    }
}