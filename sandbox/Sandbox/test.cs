using System;

public class testN
{
    public void display()
    {
        Console.WriteLine("Going to sleep for a second...");
    
        Thread.Sleep(1000);
    
        Console.WriteLine("I'm back!!");

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(3);
        Console.WriteLine($"{startTime}");
        Console.WriteLine($"{futureTime}");

        Thread.Sleep(3000);

        DateTime currentTime = DateTime.Now;
        if (currentTime < futureTime)
        {
        Console.WriteLine("We have not arrived at our future time yet...");
        }
        else{
            Console.WriteLine("HELL YEAH");
        }

        Console.WriteLine("Enter seconds: ");
        int _seconds = int.Parse(Console.ReadLine());
        DateTime start = DateTime.Now;
        DateTime future = start.AddSeconds(_seconds);
        
    }
    
}