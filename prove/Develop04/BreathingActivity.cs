using System;
using System.Xml.Serialization;

class Breathingactivity : Activity
{
    protected int _seconds;
    public Breathingactivity(string choice) : base(choice)
    {
        base.WelcomeMessage();
    }
    public void Breathing(int time)
    {
        _seconds = time;
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(_seconds);
        if(DateTime.Now <= end)
        {
            Console.Write($"Breathe in...");

            base.NumberAnimation(3);

            Console.WriteLine();
            Console.Write($"Now breathe out...");

            base.NumberAnimation(5);

            Console.WriteLine();
        }
    }
    
}