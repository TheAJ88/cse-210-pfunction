using System;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int g = int.Parse(grade);
        string letter = "";
        string sign = "";
        int lastDigit = g%10;
        if (g>=90)
        {
            letter = "A";
        }
        else if (g >= 80)
        {
            letter = "B";
        }
        else if (g>=70)
        {
            letter = "C";
        }
        else if (g>=60)
        {
            letter = "D";
        }
        else if(g<60)
        {
            letter = "F";
        }
        if(lastDigit>=7)
        {
            sign = "+";
        }
        else if (lastDigit<3)
        {
            sign = "-";
        }
        if(letter == "A" || letter == "F")
        {
            Console.WriteLine($"Your grade is {letter}.");
        }
        else
        {
            Console.WriteLine($"Your grade is {letter} {sign}.");                
        }
        if(g>70 || g==70)
        {
            Console.WriteLine("You have passed.");
        }
        else
        {
            Console.WriteLine("You have failed.");
        }




    }
}