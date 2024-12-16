using System;

class ReflectingActivity : Activity
{
    protected int _seconds;

    public ReflectingActivity(string choice) : base(choice)
    {
        base.WelcomeMessage();
    }
    public string ReflectPromptGen()
    {
        List<string> _reflectPrompts = new List<string>
    {
        "Think of a time you lost something valuable",
        "Think of a time you got hurt physically",
        "Think of a time you hurt someone with your words",
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
        "Think of a time you failed in achieving a goal you set"
    };
        Random randomnumgenerator = new Random();
        int randy = randomnumgenerator.Next(0, _reflectPrompts.Count);
        return _reflectPrompts[randy];
    }
    public string PonderPromptGen()
    {
        List<string> _ponderPrompts = new List<string>
        {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What is the most memorable thing about this experience?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
        "What could you learn from this experience that applies to other situations?"
        };

        Random randomnumgenerator = new Random();
        int randy = randomnumgenerator.Next(0, _ponderPrompts.Count);
        return _ponderPrompts[randy];
    }
    public void Reflecting(int time)
    {
        _seconds = time;
        Console.WriteLine("Consider the following prompt: \n");
        Console.WriteLine($" --- {ReflectPromptGen()} --- ");
        Console.WriteLine("When you have something in mind, press enter to continue.\n");
        bool _key = base.KeyEnter();
        if(_key==true)
        {
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
            Console.Write($"You may begin in: ");
            base.NumberAnimation(3);
            DateTime start = DateTime.Now;
            DateTime end = start.AddSeconds(_seconds);
            string _prompt1 = PonderPromptGen();
            string _prompt2 = PonderPromptGen();
            while(_prompt1==_prompt2)
            {
                _prompt2 = PonderPromptGen();
            }
            while(DateTime.Now <= end)
            {
                Console.Clear();
                Console.Write($"> {_prompt1} ");
                base.LoadingAnimation(_seconds/2);
                Console.WriteLine();
                Console.Write($"> {_prompt2} ");
                base.LoadingAnimation(_seconds/2);
                Console.WriteLine();
            }
        }
    }
}