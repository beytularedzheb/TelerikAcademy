using System;
using System.Threading;
using System.Collections.Generic;

class FallingRocks
{
    static int playerPositionX = 0;
    static int playerPositionY = 0;

    static int gameFieldWidth = 20;
    static double score = 0;

    static string dwarf = "(0)";

    static char[] rocksBody = new char[] {'^', '@', '*', '&', '+', '%', 
                            '$', '#', '!', '.', ';', '-'};

    static Random randomGen = new Random();

    struct Rock
    {
        public int x;
        public int y;
        public string body;
        public ConsoleColor color;
    }


    static void Main(string[] args)
    {
        List<Rock> rocks = new List<Rock>();

        int livesCount = 5;

        SetGameField();

        while (true)
        {
            Rock newRock = new Rock();
            newRock.x = randomGen.Next(0, gameFieldWidth);
            newRock.y = 0;
            newRock.body = rocksBody[randomGen.Next(0, 11)].ToString();

            newRock.color = ConsoleColor.Green;

            rocks.Add(newRock);

            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                while (Console.KeyAvailable)
                    Console.ReadKey();
                MovePlayer(key);
            }

            Console.Clear();

            List<Rock> newListRock = new List<Rock>();
            for (int i = 0; i < rocks.Count; i++)
            {
                Rock oldRock = rocks[i];
                Rock nRock = new Rock();

                nRock.x = oldRock.x;
                nRock.y = oldRock.y + 1;
                nRock.body = oldRock.body;
                nRock.color = oldRock.color;

                if (nRock.y == playerPositionY && nRock.x >= playerPositionX && nRock.x <= playerPositionX + 2)
                {
                    livesCount--;
                    rocks.Clear();
                    Console.Beep();
                    if (livesCount <= 0)
                    {
                        PrintMSG(10, 8, "GAME OVER", ConsoleColor.Red);
                        PrintMSG(10, 9, "Score: " + Math.Round(score, 1), ConsoleColor.Red);
                        PrintMSG(4, 10, "Press ENTER to exit...", ConsoleColor.Red);
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                }

                if (nRock.y < Console.WindowHeight)
                {
                    newListRock.Add(nRock);
                }

            }
            score += 0.1;
            rocks = newListRock;

            foreach (Rock rock in rocks)
            {
                PrintMSG(rock.x, rock.y, rock.body, rock.color);
            }

            WriteOnPosition(playerPositionX, playerPositionY, ConsoleColor.White);

            PrintMSG(21, 4, "Live: " + livesCount, ConsoleColor.Yellow);
            PrintMSG(21, 5, "Score:" + Math.Round(score, 1), ConsoleColor.Cyan);

            Thread.Sleep(150);
        }
    }

    static void PrintMSG(int x, int y, string ch, ConsoleColor color)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(ch);
    }

    static void SetGameField()
    {
        Console.BufferWidth = Console.WindowWidth = 30;
        Console.BufferHeight = Console.WindowHeight = 20;


        playerPositionX = gameFieldWidth / 2;
        playerPositionY = Console.WindowHeight - 1;
    }

    static void MovePlayer(ConsoleKeyInfo key)
    {
        if (key.Key == ConsoleKey.RightArrow)
        {
            if ((playerPositionX) < gameFieldWidth - 2)
            {
                playerPositionX++;
            }
        }
        else if (key.Key == ConsoleKey.LeftArrow)
        {
            if (playerPositionX > 0)
            {
                playerPositionX--;
            }
        }
    }

    static void WriteOnPosition(int x, int y, ConsoleColor col)
    {
        Console.ForegroundColor = col;
        Console.SetCursorPosition(x, y);
        Console.Write(dwarf);
    }
}
