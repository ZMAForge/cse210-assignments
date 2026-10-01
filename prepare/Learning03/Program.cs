using System;
using System.Data.Common;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Console.Write("What is the magic number? ");
        Random randomGenerator = new Random();
        int mNum = randomGenerator.Next(1,101);
        int guess = 0;
        int counter = 0;

        do
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            counter ++;

            if (guess == mNum)
            {
                Console.WriteLine("You guessed it!");
            } else if (guess > mNum)
            {
                Console.WriteLine("You need to guess Lower");
            } else
            {
                Console.WriteLine("You need to guess Higher");
            }
        } while (guess != mNum);
    }
}