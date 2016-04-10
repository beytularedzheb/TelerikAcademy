using System;

/*
 * Write a program that prints all possible cards from a standard deck of 52 cards 
 * (without jokers). The cards should be printed with their English names. 
 * Use nested for loops and switch-case.
 */ 

class PrintCardsName
{
    static void Main(string[] args)
    {
        string[] cardsColors = new string[] { "spades", "hearts", "clubs", "diamonds" };

        for (byte i = 0; i < cardsColors.Length; i++)
        {
            for (byte j = 2; j < 15; j++)
            {
                Console.WriteLine(GetCardsName(j) + " of " + cardsColors[i]); 
            }

            Console.WriteLine();
        }
    }

    static string GetCardsName(byte numOfCard)
    {
        switch (numOfCard)
        {
            case 2:
                return "Two";
            case 3:
                return "Three";
            case 4:
                return "Four";
            case 5:
                return "Five";
            case 6:
                return "Six";
            case 7:
                return "Seven";
            case 8:
                return "Eight";
            case 9:
                return "Nine";
            case 10:
                return "Ten";
            case 11:
                return "Ace";
            case 12:
                return "Jack";
            case 13:
                return "Queen";
            case 14:
                return "King";
            default:
                return "Error";
        }
    }
}

