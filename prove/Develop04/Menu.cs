using System;

class Menu
{
    private string _choice;
    public void ActivityCaller()
    {
        Console.WriteLine("Welcome to the the Mindfulness Activity!");
        Console.WriteLine();
        QuoteGen quote = new QuoteGen();
        quote.QuoteSend();
        Console.WriteLine();
        int _seconds = 0;
        int _blog = 0;
        int _rlog = 0;
        int _lilog = 0;
        while(_choice!="5")
        {
            Console.WriteLine(@"Please pick an activity
    1. Breathing Activity
    2. Reflecting Activty
    3. Listing Activity
    4. Activity Log
    5. QUIT");
            Console.Write("Enter your choice: ");
            _choice = Console.ReadLine();
            if(_choice=="1")
            {
                Breathingactivity ba = new Breathingactivity(_choice);
                _seconds = ba.InitializeSeconds();
                Console.Clear();
                Console.WriteLine("Get ready...");
                ba.LoadingAnimation(3);
                ba.Breathing(_seconds);
                ba.EndMessage(_seconds);
                _blog++;
            }
            if(_choice=="2")
            {
                ReflectingActivity ra = new ReflectingActivity(_choice);
                _seconds = ra.InitializeSeconds();
                Console.Clear();
                Console.WriteLine("Get ready...");
                ra.LoadingAnimation(3);
                ra.Reflecting(_seconds);
                ra.EndMessage(_seconds);
                _rlog++;
            }
            if(_choice=="3")
            {
                ListingActivity la = new ListingActivity(_choice);
                _seconds = la.InitializeSeconds();
                Console.Clear();
                Console.WriteLine("Get ready...");
                la.LoadingAnimation(3);
                la.Listing(_seconds);
                Console.WriteLine($"You listed {la.GetCounter()} items!\n");
                la.EndMessage(_seconds);
                _lilog++;
            }
            if(_choice=="4")
            {
                ActivityLog activity = new ActivityLog();
                activity.Log(_blog, _rlog, _lilog);
            }
        }
        Console.WriteLine("Thank you for participating! See you next time!");
    }
}

