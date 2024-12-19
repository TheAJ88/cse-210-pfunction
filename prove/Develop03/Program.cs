using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Scripture Memorizer!");
        Console.WriteLine("What book would you like to memorize a verse from?");
        Console.WriteLine(@"
        1) OLD TESTAMENT
        2) NEW TESTAMENT
        3) BOOK OF MORMON
        4) PEARL OF GREAT PRICE
        5) DOCTRINE AND COVENANTS");
        int _bookChoice = int.Parse(Console.ReadLine());
        string _scripture = "";
        Reference reference = new Reference("GENESIS", 1, 1);
            if(_bookChoice==1)
            {
                LoadScriptures custom = new LoadScriptures();
                custom.Loader("OLD TESTAMENT");
                _scripture = custom.GetScripture();
                reference = custom.GetReference();
            }
            if(_bookChoice==2)
            {
                LoadScriptures custom = new LoadScriptures();
                custom.Loader("NEW TESTAMENT");
                _scripture = custom.GetScripture();
                reference = custom.GetReference();
            }
            if(_bookChoice==3)
            {
                LoadScriptures custom = new LoadScriptures();
                custom.Loader("BOOK OF MORMON");
                _scripture = custom.GetScripture();
                reference = custom.GetReference();
            }
            if(_bookChoice==4)
            {
                LoadScriptures custom = new LoadScriptures();
                custom.Loader("PEARL OF GREAT PRICE");
                _scripture = custom.GetScripture();
                reference = custom.GetReference();
            }
            if(_bookChoice==5)
            {
                LoadScriptures custom = new LoadScriptures();
                custom.Loader("DOCTRINE AND COVENANTS");    
                _scripture = custom.GetScripture();
                reference = custom.GetReference();
            }
        Scripture scripture = new Scripture(reference, _scripture);
        while (scripture.AllWordsHidden()!=true)
        {
            Console.Clear();
            Console.WriteLine(scripture.Display());
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            scripture.HideRandomWords(3); 
        }

        if (scripture.AllWordsHidden())
        {
            Console.WriteLine("Congratulations! You've memorized the scripture.");
        }
    }
    
}