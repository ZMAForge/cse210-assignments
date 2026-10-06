class Menu
{
    public int ProcessMenu()
    {
        Console.WriteLine("In the menu Class");
        int input = 0;
        while (input is < 1 || input > 5)
        {
            Console.WriteLine("Welcome to the Journal Program.");
            Console.WriteLine("Create, Display, Save or Read Journal Entries.");
            Console.WriteLine("1. Create new journal entry.");
            Console.WriteLine("2. Display all journal entry.");
            Console.WriteLine("3. Save journal entry.");
            Console.WriteLine("4. Read journal from a file.");
            Console.WriteLine("5. Quit.");
            Console.Write("  > ");
            input = int.Parse(Console.ReadLine());
        }
        return input;
    }
}