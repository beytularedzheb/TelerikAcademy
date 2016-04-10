using System;

class HelloName
{
    static void Main()
    {
        Console.Write("What is your name? ");
        SayHelloToUser(Console.ReadLine());
    }

    static void SayHelloToUser(string userName)
    {
        Console.WriteLine("Hello, {0}!", userName);
    }
}

