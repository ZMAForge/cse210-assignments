using System;
using System.ComponentModel;
using System.Net;
using System.Threading.Channels;

class Program
{
    static void Main(string[] args)
    {
        string response = "";
        bool canHide = true;
        Scripture MyScripture = new Scripture("Moses", 1, 39, 
            "Behold, this is my work and my glory, to bring to pass the immortality and eternal life of man");
        while (response != "quit" && canHide) 
        {
            MyScripture.ShowScripture();
            Console.Write("\nPress Enter to hide more words. Type Quit to leave.\n\n  > ");
            response = Console.ReadLine();
            canHide = MyScripture.HideSomeWords();
        }
        MyScripture.ShowScripture();
        Console.WriteLine("Scripture is completely hidden. Good Job!");
    }
}