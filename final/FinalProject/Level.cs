using System;
using System.Security.Cryptography.X509Certificates;

abstract class Level
{
    public abstract void StartMessage();
    public abstract void EndMessage();
}