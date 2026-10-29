using System;
using System.Data;
using System.Globalization;
using System.Numerics;
using System.Runtime.Serialization.Formatters;
using System.Security.Principal;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning04 World!");
        // List<int> numbers = new List<int>();
        // int num = -1;
        // int lNum = 0;
        // int total = 0;

        // Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        // while (num != 0)
        // {
        //     Console.Write("Enter a number: ");
        //     num = int.Parse(Console.ReadLine());
        //     numbers.Add(num);

        //     if (lNum < num)
        //     {
        //         lNum = num;
        //     }
        // }
        //     foreach (int i in numbers)
        //     {
        //         total += i;
        //     }
        //     Console.WriteLine($"The Sum is {total}");
        //     float average = ((float)total)/numbers.Count;
        //     Console.WriteLine($"The Average is {average}");
        //     Console.WriteLine($"THe largest number was {lNum}");
        Assignment myAssignment = new Assignment("Zelda Asvitt", "Inheritance");
        Console.WriteLine(myAssignment.GetSummary());
        MathAssignment myMathAssignment = new MathAssignment("Zelda Asvitt", "Multiplication", "Section 7.3", "Problems 8-19");
        Console.WriteLine(myMathAssignment.GetSummary());
        Console.WriteLine(myMathAssignment.GetHomeWorkList());
        WritingAssignment myWritingAssignment = new WritingAssignment("Zelda Asvitt", "Philosphy", "A Study on the Character Aligment Chart on Players");
        Console.WriteLine(myWritingAssignment.GetSummary());
        Console.WriteLine(myWritingAssignment.GetWritingAssigment());
    }
}