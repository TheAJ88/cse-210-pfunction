using System;

class IntroHQ : Level
{
    TypeOutMessage message = new TypeOutMessage();
    public override void StartMessage()
    {
        message.SlowType("Welcome to HQ, NE317!");
        message.SlowType(@"RAIKIN 7E is the the MINING CORPS latest venture. We need you to go out
and secure the planet for the mine drones to arrive.");
        message.SlowType("Since you're fresh out of cryo, we've prepared a training session for you.");
        message.SlowType("Good luck, NE317!");
    }

    public override void EndMessage()
    {
        message.SlowType("You've completed the training session. We're gonna deploy you to the surface now. Good luck NE317!");
    }
}