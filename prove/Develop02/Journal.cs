using System.Net.Http.Headers;
using System.IO;

class Journal
{
    public List<JournalEntry> _entries = new List<JournalEntry>();

    public void DisplayJournal()
    {
        foreach(JournalEntry entry in _entries)
        {
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
        Console.WriteLine($"Saving {_entries.Count} entries");
        
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
            JournalEntry entry = new JournalEntry();
            string[] parts = line.Split("#");
            entry._date = parts[0];
            entry._prompt = parts[1];
            entry._response = parts[2];

            _entries.Add(entry);
        }
    }
}