using System;
using System.Threading;

class nProgram
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");

        // for(int i=0; i<=10; i++)
        // {
        //     Console.WriteLine(i);
        //     Console.WriteLine("Boom.");
        // }

        // testN t = new testN();
        // t.display();
        // childTest cT = new childTest();
        // cT.Display();

        // Animation a  = new Animation();
        // a.printer();
        // SAMELINE cs = new SAMELINE();
        // cs.sameLiner();
        string message = "This is being typed out...";
        int typingSpeed = 50;  //milliseconds delay between each character

        TypeOutMessage(message, typingSpeed);
        static void TypeOutMessage(string message, int delay)
        {
        foreach (char c in message)
        {
            Console.Write(c);
            Thread.Sleep(delay);
        }
        Console.WriteLine(); // Move to the next line after the message is fully typed
        }

    }
    

}