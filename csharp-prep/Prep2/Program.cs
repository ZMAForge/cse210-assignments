using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your percentage in your class? ");
        int grade = int.Parse(Console.ReadLine());
        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80 && grade < 90)
        {
            letter = "B";
        }
        else if (grade >= 70 && grade < 80)
        {
            letter = "C";
        }
        else if (grade >= 60 && grade < 70)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        int key = grade % 10;
        string sign = "";
        if (key >= 7 && letter != "A" && letter != "F")
        {
            sign = "+";
        }
        else if (key < 3 && letter != "F")
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }
        
        Console.WriteLine($"Your Grade is {letter}{sign}");

        if (grade > 70)
        {
            Console.WriteLine("You have Passed your class! Congratulations!");
        }
        else
        {
            Console.WriteLine("You did not pass this time.. Keep studying and you will have it next time!");
        }
    }
}