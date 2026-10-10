using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();
        Journal myJournal = new Journal();

        int response = 0;

        while(response != 5)
        {
            response = myMenu.ProcessMenu();
            switch(response)
            {
                case 1:
                // Call CreateJournalEntry()
                    Console.WriteLine("Create");
                    myJournal.CreateEntry();
                break;
                case 2:
                // Call DisplayJournal()
                    Console.WriteLine("Display");
                    myJournal.DisplayJournal();
                break;
                case 3:
                // Call ReadFromFile
                    Console.WriteLine("Read");
                    // Call ReadFromFile
                    myJournal.ReadFromFile("journal.csv");
                break;
                case 4:
                // Call WriteToFile
                    Console.WriteLine("Save");
                    // Call WriteToFile
                    myJournal.WriteToFile("journal.csv");
                break;
            }
        }
    }
}