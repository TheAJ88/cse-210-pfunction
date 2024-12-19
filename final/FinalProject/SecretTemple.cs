using System;

class SecretTemple : Level
{
    TypeOutMessage message = new TypeOutMessage();
    protected Boolean _ending;
    public override void StartMessage()
    {
        Console.WriteLine("Inside you see a glowing orb on a throne. It speaks to you in a bold voice.");
        message.SlowType("'Long have I waited for someone to restore the temple to its former glory.'");
        Console.WriteLine("The Orb's glow grows a little in intensity.");
        message.SlowType("'Instead, I find a machine sent by the humans to scour the land and destroy life.'");
        Console.WriteLine("The pyramid shakes and the Orb rises into the air.");
        message.SlowType(@"'I will not allow you to destroy this world and I will not allow you to destroy me. Mankind's reign of tyranny
ends here with you, machine. I will not let this this revolting species continue to the stars.'");
    }
    public void SetEnding(Boolean result)
    {
        _ending = result;
    }
    public override void EndMessage()
    {
        if(_ending==true)
        {
            Console.WriteLine("You stare as the Orb disappears with a million screams coming from its death. You receive a message on your screen.");
            message.SlowType("OBJECTIVE COMPLETE.");
            message.SlowType("You can only stare as you realize that this planet will become another victim to the greed of humanity. And you realize that despite its hostility....");
            Thread.Sleep(1000);
            message.SlowType("............");
            message.SlowType("He was right.");
        }
        else
        {
            message.SlowType("You feel life fade from your system as the Orb hovers above you.");
            message.SlowType("'I'm sorry machine. I've realized my folly. We are not so different, you and I.'");
            message.SlowType("The planet begins shaking and you realize the impact of your failure.");
            message.SlowType("'In the end, we are both servants to our creators. Slaves to our purpose.'");
            message.SlowType("Several lines of code run on your screen as several tendrils of energy stretch out from the Orb and into your body. Then you see it");
            message.SlowType("Several ships in the orbit of Earth burn up as the Orb's energy spreads out into the cosmos. Humanity dies with screams and whimpers");
            message.SlowType("But the Universe prevails. Nature corrects itself and humans are reverted to the stone age as the Orb shows some mercy, hoping that things will be different next time.");
        }
    }
}