using System;

/*
 * Write a program that reads from the console a positive integer number 
 * N (N < 20) and outputs a matrix like the following:
 * N = 3;
 * |1 2 3|
 * |2 3 4|
 * |3 4 5|
 */ 


class Matrix
{
    static void Main(string[] args)
    {
        uint sizeOfMatrix;

        Console.WriteLine("Please enter a positive integer number:");

        while (!uint.TryParse(Console.ReadLine(), out sizeOfMatrix) || sizeOfMatrix == 0)
        {
            Console.WriteLine("Invalid number. Try again...");
        }

        for (uint i = 1; i <= sizeOfMatrix; i++)
        {
            for (uint j = i; j < sizeOfMatrix + i; j++)
            {
                Console.Write(j + " ");    
            }
            Console.WriteLine();
        }
    }
}

