using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
        Console.Write("What is your first name? ");
        string n1 = Console.ReadLine();
        Console.Write("What is your last name? ");
        string n2 = Console.ReadLine();
        Console.WriteLine($"Your name is {n2}, {n1} {n2}.");

    }
}
