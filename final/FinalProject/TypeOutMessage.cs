using System;

class TypeOutMessage
{
        public void SlowType(string message)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(50);
            }
            Console.WriteLine(); 
        }
}