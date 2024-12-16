using System;

public class ListingActivity : Activity
{
    protected int _seconds;
    protected List<string> _prompts;
    protected int _counter;
    protected int _timer;
    public ListingActivity(string choice) : base(choice)
    {
        base.WelcomeMessage();
        _timer = _seconds;
    }

    public string ListingPromptGen()
    {
        _prompts = new List<string>
        {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
        "What are the foods that mean a lot to you?",
        "What are some movies that inspire you?",
        "Who are people you should try being good to?"
        };

        Random randomnumgenerator = new Random();
        int randy = randomnumgenerator.Next(0, _prompts.Count);
        return _prompts[randy];
    }

    public void Listing(int time)
    {
        _timer = time; 
        Console.WriteLine("List as many responses as you can to the following prompt: \n");
        Console.WriteLine($" --- {ListingPromptGen()} --- ");
        Console.Write($"You may begin in ");
        base.NumberAnimation(5);
        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_timer);
        while(DateTime.Now <= futureTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            _counter++;
        }
    }
    public int GetCounter()
    {
        return _counter;
    }
}