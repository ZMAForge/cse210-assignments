using System;
using System.Data.Common;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        // Testing
        // Fraction fraction1 = new Fraction();
        // Fraction fraction2 = new Fraction(6);
        // Fraction fraction3 = new Fraction(6, 7);
        // Console.WriteLine(fraction1.GetBottom());
        // Console.WriteLine(fraction2.GetTop());
        // fraction3.SetTop(3);
        // fraction3.SetBottom(6);
        // Console.WriteLine(fraction3.GetTop());
        // Console.WriteLine(fraction3.GetBottom());

        // Console.WriteLine(fraction1.GetDecimalValue());
        // Console.WriteLine(fraction2.GetDecimalValue());
        // Console.WriteLine(fraction2.GetFractionString());
        // Console.WriteLine(fraction3.GetFractionString());
        // Console.WriteLine(fraction3.GetDecimalValue());

        Fraction fraction4 = new Fraction();
        Random random = new Random();
        int counter = 0;
        while (counter < 20)
        {
            int top = random.Next(1,50);
            int bottom = random.Next(1,6);
            fraction4.SetTop(top);
            fraction4.SetBottom(bottom);
            Console.WriteLine($"Fraction 1: string: {fraction4.GetFractionString()} Number: {fraction4.GetDecimalValue()}");
            counter ++;
        }
    }
}