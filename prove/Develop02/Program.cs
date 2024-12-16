using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices:"); 
        int _control = 0;
        Journal2 journal = new Journal2();
        while(_control==0)
        {
            Console.WriteLine(@"
1. Write
2. Display
3. Load
4. Save
5. Quit");
            Console.WriteLine("What would you like to do? ");
            string option = Console.ReadLine();
            if(option=="1")
            {
                journal.EntryManager();
            }
            if(option=="2")
            {
                journal.Display();
            }
            if(option=="3")
            {
                Console.WriteLine("ENTER FILENAME: ");
                string f = Console.ReadLine();
                journal.Loadfile(f);
            }
            if(option=="4")
            {
                Console.WriteLine("ENTER FILENAME TO BE SAVED: ");
                string f = Console.ReadLine();
                journal.Savefile(f);
            }
            if(option=="5")
            {
                _control = 1;
            }
            
        };

    }
}