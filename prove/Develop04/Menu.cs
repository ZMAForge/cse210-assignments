using System.Diagnostics;
using System.Net;

class Menu
{
    BreathingActivity _breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
    ListingActivity _listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    ReflectionActivity _reflectionActivity = new ReflectionActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    
    public void DisplayMenu()
    {
        int response = 0;
        while(response != 4)
        {
            Console.WriteLine("Menu Options:\n  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity\n  3. Start listing activity");
            Console.WriteLine("  4. Quit\nSelect a choice from the menu: ");
            response = int.Parse(Console.ReadLine());
            
            switch (response)
            {
                case 1:
                    _breathingActivity.RunActivity();
                    break;
                case 2:
                    _reflectionActivity.RunActivity();
                    break;
                case 3:
                    _listingActivity.RunActivity();
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
        Console.WriteLine("Thank you for practicing mindfulness! Have a good day!");
    }
}