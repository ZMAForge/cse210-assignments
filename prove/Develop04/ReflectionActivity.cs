using System.Diagnostics;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

class ReflectionActivity : BaseActivity
{
    List<string> _prompts;
    List<string> _question;

    public ReflectionActivity(string name, string description): base(name, description)
    {
        _prompts = [
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        ];
        _question = [
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        ];
    }

    public void RunActivity()
    {
        StartActivity();
        RunCountdownMessage("Get Ready", 5);

        Console.WriteLine("Consider the Following Prompt:");
        Console.WriteLine($" --- {GetPrompt()} --- ");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions in relation to this experience.");
        RunCountdownMessage("You may begin in: ", 3);
        StartTimer();
        
        int num = 0;
        while(! HasTimerExpired())
        {
            Console.WriteLine(_question[num]);
            num++;
            Thread.Sleep(15000);
        }

        DisplayEnding();
    }

    private string GetPrompt()
    {
        Random ranprompt = new Random();
        int num = ranprompt.Next(0, _prompts.Count);
        return _prompts[num];
    }
}