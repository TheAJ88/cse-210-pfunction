using System;

class Animation
{
    public void printer()
    {
        int c = 0;
        // while(c<5)
        // {
        //     Console.Write("+");

        //     Thread.Sleep(500);

        //     Console.Write("\b \b"); // Erase the + character
        //     Console.Write("-"); // Replace it with the - character
        //     Thread.Sleep(500);
        //     Console.Write("\b \b");
        //     c++;
        // }
        Console.Clear();
        while(c<3)
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
            
            c++;
        }
        Console.WriteLine("Get ready...");
        for(int x = 0; x<5; x++)
        {
            Console.Write($"Breathe in...");
            for(int i = 3; i>0; i--)
            {
                Console.Write($"{i}");
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();
            Console.Write($"Now breathe out...");
            for(int j = 5; j>0; j--)
            {
                Console.Write($"{j}");
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();
        }
    }
}