using System;

class Program
{
    static void Main(string[] args)
    {
        int totalScore = 0;
        SimpleGoal mySimpleGoal = new SimpleGoal();
        Console.WriteLine(mySimpleGoal.GetConsoleString());
        totalScore = totalScore + mySimpleGoal.RecordEvent();
        Console.WriteLine(totalScore);

        EternalGoal myEternalGoal = new EternalGoal();
        totalScore = totalScore + myEternalGoal.RecordEvent();
        Console.WriteLine(myEternalGoal.GetConsoleString());
        Console.WriteLine(totalScore);

        totalScore = totalScore + myEternalGoal.RecordEvent();
        totalScore = totalScore + myEternalGoal.RecordEvent();
        totalScore = totalScore + myEternalGoal.RecordEvent();
        Console.WriteLine(myEternalGoal.GetConsoleString());
        Console.WriteLine(totalScore);
    }
}