using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("WELCOME TO THE SCRIPTURE PROGRAM!");
        Console.WriteLine(@"Choose your memorizer: 
        1. GET A RANDOM VERSE TO MEMORIZE
        2. PICK A BOOK AND RECIEVE A RANDOM VERSE FROM IT
        3. INPUT A CUSTOM VERSE TO MEMORIZE");
        string option = Console.ReadLine();
        Scripture sc = new Scripture();
        sc.SetOption(option);
    }
}