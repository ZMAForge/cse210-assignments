using System;

class Program
{
    static void Main(string[] args)
    {
        Word MyWord = new Word("Secret");
        MyWord.Hide();
        MyWord.Display();
    }
}