using System;

class LoadingAnimation
{
    public LoadingAnimation(int time)
        {
            int _loadingTime = time;
            while(_loadingTime>0)
            {
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the + character

            Console.Write("/"); // Replace it with the - character
            Thread.Sleep(500);
            Console.Write("\b \b");

            Console.Write("-"); // Replace it with the - character
            Thread.Sleep(500);
            Console.Write("\b \b");

            Console.Write("\\"); 
            Thread.Sleep(500);
            Console.Write("\b \b");
            _loadingTime--;
            }
        }
}