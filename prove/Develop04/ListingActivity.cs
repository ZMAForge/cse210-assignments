using System.Net;
using System.Net.Quic;

class ListingActivity : BaseActivity
{
    private List<string> _prompts;
    public ListingActivity(string name, string description): base(name, description)
    {
        _prompts = 
        [
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        ];
    }
    

    private void SetPrompts()
    {
        string userResponse = "";
        while(userResponse != "quit")
        {
            Console.WriteLine("Enter prompt. Enter 'quit' to stop > ");
            userResponse = Console.ReadLine();
            if(userResponse != "quit")
            {
                _prompts.Add(userResponse);
            }
        }
        
    }
    
    public void RunActivity()
    {
        StartActivity();
        RunCountdownMessage("Get Ready", 5);
        StartTimer();

        Random myran = new Random();
        int index = myran.Next(0, _prompts.Count);
        int count = 0;

        RunCountdownMessage("You may begin in:", 5);
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($" --- {_prompts[index]} --- ");
        
        while(! HasTimerExpired())
        {
            Console.Write(" > ");
            Console.ReadLine();
            count++;
        }
        Console.WriteLine($"You listed {count} items");
        DisplayEnding();
    }
}