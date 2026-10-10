class JournalEntry
{
    public string _date;
    public string _prompt;
    public string _response;

    public void DisplayJournalEntry()
    {
        Console.WriteLine("DisplayJournalEntry Successful");
        Console.WriteLine($"{_date}, {_prompt}");
        Console.WriteLine($"{_response}");
    }

    public string CreateJournalEntry()
    {
        Console.WriteLine("CreateJournalEntry Triggered");
        string [] prompts =
        {
            "How was your day?",
            "Talk about someone you met today",
            "What was a small thing you noticed today?"
        };
        _date = DateTime.Now.ToString();
        _prompt = prompts[0];
        Console.Write($"{_prompt}: ");
        _response = Console.ReadLine();
        Console.WriteLine(_response);
        return _response;
    }
    public string CreateFileSystemString(string _date, string _prompt, string _response)
    {
        string outputString = "";
        outputString = $"{_date}#{_prompt}#{_response}";
        return outputString;
    }
}