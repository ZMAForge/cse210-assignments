using System;

class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();
        // TODO: Create Menu
        int response = 0;

        response = myMenu.ProcessMenu();
        while(response != 5)
        {
            switch(response)
            {
                case 1:
                // Call CreateJournalEntry()
                    Console.WriteLine("Create");
                break;
                case 2:
                // Call DisplayJournal()
                    Console.WriteLine("Display");
                break;
                case 3:
                // Call ReadFromFile
                    Console.WriteLine("Save");
                break;
                case 4:
                // Call WriteToFile
                    Console.WriteLine("Write");
                break;
            }
            response = myMenu.ProcessMenu();
        }
    }
}