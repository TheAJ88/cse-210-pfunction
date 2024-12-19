using System;

class Wasteland : Level
{
    protected int _decider;
    protected int _trigger;
    TypeOutMessage message = new TypeOutMessage();
    protected Character _player;

    public void SetPlayer(Character player)
    {
        _player = player;
    }
    public override void StartMessage()
    {
        Console.WriteLine("RAIKIN 7E");
        Console.WriteLine("The Wasteland lays barren in front of you. The ground is a pale green with occasional patches of mist and dead trees standing tall.");
        Console.WriteLine("What do you do?");
        Console.WriteLine("1. EXPLORE");
        Console.WriteLine("2. STAT REPORT");
        Console.WriteLine("3. _terminateLife.exe");
        string input = Console.ReadLine();
        if(input=="1")
        {
            Console.WriteLine("You decide to explore the Wasteland.");
            _decider = 1;
        }
        if(input=="2")
        {
            _decider = 2;
        }
        if(input=="3")
        {
            message.SlowType(@"As you stare at the Wasteland, the futility of your existence dawns upon you. You turn off you visual input for the last time
 and watch as the world fades to black. You finally feel no pain, no fear, no regret. You are free.");
            _decider = 3;
        }
    }

    public int GetDecider()
    {
        return _decider;
    }
    public override void EndMessage()
    {
        message.SlowType("The Earth quakes as a metallic pyramid rises out from the ground, tearing the Earth and slime as everything displaces.");
        message.SlowType("The pyramid is silver with blue glowing lines adorning its edges. It is a technological marvel, a relic of the past.");
        message.SlowType("You hear a voice coming from inside. It calls to you.");
        Thread.Sleep(1000);
        message.SlowType("You accept.");
    }
}