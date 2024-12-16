using System;
using System.Security.Cryptography.X509Certificates;

abstract class Level
{
    protected string _trigger;
    public abstract void WelcomeMessage(){}
    public abstract void VictoryMessage(){}
}