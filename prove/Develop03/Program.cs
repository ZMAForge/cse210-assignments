using System;
using System.Threading.Channels;

class Program
{
    static void Main(string[] args)
    {
        Scripture MyScripture = new Scripture("Moses", 1, 39, 
            "Behold, this is my work and my glory, to bring to pass the immortality and eternal life of man");
        MyScripture.ShowScripture();
    }
}