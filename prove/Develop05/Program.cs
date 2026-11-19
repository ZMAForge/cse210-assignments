using System;

class Program
{
    static void Main(string[] args)
    {
        BaseGoal myGoal = new BaseGoal("Base Goal");
        Console.WriteLine(myGoal.GetConsoleString());
    }
}