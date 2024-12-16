using System;
using System.Globalization;
using System.Xml.Serialization;

public class Promptgen
{
    public List<string> _entryPrompt = new List<string>();
    public Promptgen()
    {

        _entryPrompt.Add("Who was the most interesting person I interacted with today?");
        _entryPrompt.Add("What was the best part of my day?");
        _entryPrompt.Add("How did I see the hand of the Lord in my life today?");
        _entryPrompt.Add("What was the strongest emotion I felt today?");
        _entryPrompt.Add("If I had one thing I could do over today, what would it be?");
        _entryPrompt.Add("What's the best thing I ate today?");
        _entryPrompt.Add("What felt like it was missing today?");
        _entryPrompt.Add("Did I manage to improve myself today?");
    }

    public string Prompt()
    {
        Random randomnumgenerator = new Random();
        int randy = randomnumgenerator.Next(0, _entryPrompt.Count);
        return _entryPrompt[randy];
    }
}
