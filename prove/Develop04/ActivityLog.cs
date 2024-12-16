using System;

class ActivityLog
{
    protected int _total;
    public void Log(int b, int r, int l)
    {
        _total = b + r + l;
        Console.WriteLine($"You've completed a total of {_total} activities!");
        Console.WriteLine($"Breating Activity : {b}");
        Console.WriteLine($"Reflect Activity : {r}");
        Console.WriteLine($"Listing Activity : {l}");
    }
}