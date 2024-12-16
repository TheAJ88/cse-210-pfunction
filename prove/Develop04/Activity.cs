using System;

public class Activity
{
    private string _choice;
    private int _seconds;
    private string _activityName;
    private string _activityDescription;
    private int _numberTime;
    private int _loadingTime;
    
    public Activity(string choice)
    {
        _choice = choice;
        if(_choice=="1")
        {
            _activityName = "Breathing Activity";
            _activityDescription = "Breathing activity description";
        }
        if(_choice=="2")
        {
            _activityName = "Reflecting Activity";
            _activityDescription = "Reflecting Activity Description";
        }
        if(_choice=="3")
        {
            _activityName = "Listing Activity";
            _activityDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        }
    }
    public int InitializeSeconds()
    {
        Console.WriteLine("How long, in seconds, would you like your session? ");
        _seconds = int.Parse(Console.ReadLine());
        while(_seconds<10)
        {
            Console.WriteLine("Please enter more than 10 seconds for the activity: ");
            _seconds = int.Parse(Console.ReadLine());
        }
        return _seconds;
    }

    public void WelcomeMessage()
    {
        Console.WriteLine($"Welcome to {_activityName}!\n");
        Console.WriteLine($"{_activityDescription}\n");
    }
    public void EndMessage(int seconds)
    {
        _seconds = seconds;
        Console.WriteLine("Well done!!");
        LoadingAnimation(3);
        Console.WriteLine($"You have completed another {_seconds} seconds of the {_activityName}");
        LoadingAnimation(3);
    }

    public void LoadingAnimation(int time)
    {
        _loadingTime = time;
        while(_loadingTime>0)
        {
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the + character

            Console.Write("/"); // Replace it with the - character
            Thread.Sleep(500);
            Console.Write("\b \b");

            Console.Write("-"); // Replace it with the - character
            Thread.Sleep(500);
            Console.Write("\b \b");

            Console.Write("\\"); 
            Thread.Sleep(500);
            Console.Write("\b \b");
            _loadingTime--;
        }
    }

    public void NumberAnimation(int time)
    {
        _numberTime = time;
        for(int i = _numberTime; i>0; i--)
            {
                Console.Write($"{i}");
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
    }

    public bool KeyEnter()
    {
        string key = Console.ReadLine();
        if(key=="")
        {
            return true;
        }
        else
        {
            Console.WriteLine("Strange input detected. Continuing anyway.");
            return true;
        }
    }
}