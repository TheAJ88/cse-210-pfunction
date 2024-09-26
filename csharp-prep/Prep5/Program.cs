using System;
using System.Data.SqlTypes;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome();
        string name = PromptUserName();
        int num = PromptUserNumber();
        int sqn = SquareNumber(num);
        DisplayResult(name,sqn);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int fav_num = int.Parse(Console.ReadLine());
        return fav_num;
    }
    static int SquareNumber(int n1)
    {
        int sqn = n1 * n1;
        return sqn;
    }
    static void DisplayResult(string n, int s)
    {
        Console.WriteLine($"{n}, the square of your number is {s}.");
    }
}