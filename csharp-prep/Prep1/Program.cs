using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
        
        Console.Write("What is your First name? ");
        string fName = Console.ReadLine();
        
        Console.Write("What is your Last name? ");
        string lName = Console.ReadLine();

        Console.WriteLine($" Your name is {lName}, {fName} {lName}.");
    }
}