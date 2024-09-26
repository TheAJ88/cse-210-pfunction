using System;
using System.Globalization;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Console.WriteLine("Welcome to the Magic number game!");
        Random randomnumgenerator = new Random();
        int magic_num = randomnumgenerator.Next(1,101);
        int tracker = 0;
        int counter = 0;
        do
        {
            Console.Write("What is the magic number? : ");
            int num = int.Parse(Console.ReadLine());
            if(num<magic_num)
            {
                Console.WriteLine("Higher");
            }
            if(num>magic_num)
            {
                Console.WriteLine("Lower");
            }
            if(num==magic_num)
            {
                Console.WriteLine("You guessed it!");
                tracker = 1;
            }
            counter++;
        } while(tracker==0);
        Console.WriteLine($"You guessed it in {counter} tries!");
    }
}