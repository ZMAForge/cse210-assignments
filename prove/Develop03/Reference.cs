class Reference
{
    private string _ref;
    public Reference (string bookName, int chapter, int verse)
    {
        _ref = $"{bookName} {chapter}: {verse}";
    }

    public Reference (string bookName, int chapter, int startVerse, int endVerse)
    {
        _ref = $"{bookName} {chapter}: {startVerse}-{endVerse}";
    }

    public void ShowReference()
    {
        Console.WriteLine(_ref);
    }
}