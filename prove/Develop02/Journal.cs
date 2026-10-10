using System.Net.Http.Headers;
using System.IO;

class Journal
{
    public List<JournalEntry> _entries = new List<JournalEntry>();

    public void DisplayJournal()
    {
        Console.WriteLine("Display Journal Triggered");
        foreach(JournalEntry entry in _entries)
        {
            Console.WriteLine("Trigger DisplayJournalEntry attempt");
            entry.DisplayJournalEntry();
        }
    }

    public void CreateEntry()
    {
        Console.WriteLine("CreateEntry Triggered");
        JournalEntry newEntry = new JournalEntry();
        Console.WriteLine("Attempt CreateJournalEntry");
        newEntry.CreateJournalEntry();
        _entries.Add(newEntry);
    }


    public void WriteToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach(JournalEntry entry in _entries)
            {
                outputFile.WriteLine(entry.CreateFileSystemString(entry._date, entry._prompt, entry._response));
            }
        }
    }


    public void ReadFromFile(string filename) {
        string [] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("#");
            string date = parts[0];
            string question = parts[1];
            string entryText = parts[2];

            JournalEntry entry = new JournalEntry();
            entry.CreateFileSystemString(date, question, entryText);
            _entries.Add(entry);
        }
    }
}