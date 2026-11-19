using System;

class Program
{
    static void Main(string[] args)
    {
        SimpleGoal mySimpleGoal = new SimpleGoal();
        Console.WriteLine(mySimpleGoal.GetConsoleString());
        mySimpleGoal.MarkComplete();
        Console.WriteLine(mySimpleGoal.GetConsoleString());
    }
}