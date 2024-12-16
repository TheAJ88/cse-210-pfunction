using System;
using System.ComponentModel;


class SAMELINE
{
    public void sameLiner()
    {
        Console.WriteLine("Enter stuff: ");
        int _c = 5;
        while(_c>0)
        {
            Console.Write("> ");
            Console.ReadLine();
            _c--;
        }
        int _timer = 15;
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_timer);
        
    }
}