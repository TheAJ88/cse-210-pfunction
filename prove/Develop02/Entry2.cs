 using System;

public class Entry2
{
    Promptgen p = new Promptgen();
    public string _prompt;
    public string _entryText;
    public string _date;
    
    public Entry2()
    {
        _prompt = p.Prompt();
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();
    }
    
    public void journalEntry()
    {
        Console.WriteLine(_prompt);
        Console.Write("> ");
        _entryText = Console.ReadLine();
    }

    public void Display()
    {
        Console.WriteLine($"{_date} {_prompt}");
        Console.WriteLine($">{_entryText}");
        Thread.Sleep(3000);
    }
}