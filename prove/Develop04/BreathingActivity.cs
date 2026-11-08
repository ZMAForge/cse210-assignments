using System.Runtime.CompilerServices;

class BreathingActivity : BaseActivity
{
    public BreathingActivity(string name, string description): base(name, description)
    {
        //ToDo
    }
    public void RunActivity()
    {
        // call StartActivity method from BaseActivity
        StartActivity();
        // DateTime endtime = DateTime.Now.AddSeconds(20)
        StartTimer();
        RunSpinnerMessage("Get Ready", 5);
        // while (DateTime.Now < endtime)
        while(! HasTimerExpired())
        {
            RunCountdownMessage("Breath In", 4);
            RunCountdownMessage("Breath out", 6);
        }
        Console.Clear();
        //call EndActivity
        DisplayEnding();
    }
}