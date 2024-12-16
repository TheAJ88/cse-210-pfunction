using System;

class childTest : baseTest
{
    private int _breathingSeconds;
    public void Display()
    {
        _breathingSeconds = initializeSeconds();
        Console.WriteLine($"{_breathingSeconds}");
    }
}