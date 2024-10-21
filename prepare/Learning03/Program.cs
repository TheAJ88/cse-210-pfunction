using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Console.WriteLine("WELCOME TO THE FRACTION PROGRAM! Here's an example to get you started!");
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Console.WriteLine("Enter a number");
        int _choice = int.Parse(Console.ReadLine());
        Fraction f2 = new Fraction(_choice);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Console.WriteLine("Enter two numbers: ");
        int _choice1 = int.Parse(Console.ReadLine());
        int _choice2 = int.Parse(Console.ReadLine());
        Fraction f3 = new Fraction(_choice1, _choice2);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
    }
}