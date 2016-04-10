using System;

class Spiral
{
    static void Main()
    {
        int n; 

        int[,] arr; // двумерният масив, в който се запазват данните
        int row = 0; // определя реда
        int col = -1; // определя колоната

        byte direction = 0; // 0 - right; 1 - down; 2 - left; 3 - up
        int level = 0; // N - level определя максимум колко стъпки могат да се "извървят" в дадена посока
        int counter = 1; // брои изминати стъпки

        Console.WriteLine("Please enter N (1 < N < 20):");

        while (!int.TryParse(Console.ReadLine(), out n) || n == 0 || n >= 20)
        {
            Console.WriteLine("Invalid number. Try again...");
        }

        arr = new int[n, n];

        for (int i = 1; i <= Math.Pow(n, 2); i++, counter++)
        {
            if (direction == 0) // right
            {
                ++col;
                arr[row, col] = i;
                if (counter == n - level)
                {
                    counter = 0;
                    direction = 1;
                    level++;
                }
            }
            else if (direction == 1) // down
            {
                ++row;
                arr[row, col] = i;
                if (counter == n - level)
                {
                    counter = 0;
                    direction = 2;
                }
            }
            else if (direction == 2) // left
            {
                --col;
                arr[row, col] = i;
                if (counter == n - level)
                {
                    counter = 0;
                    direction = 3;
                    level++;
                }
            }
            else if (direction == 3) // up
            {
                --row;
                arr[row, col] = i;
                if (counter == n - level)
                {
                    counter = 0;
                    direction = 0;
                }
            }
        }

        PrintArray(arr, n);
    }

    static void PrintArray(int[,] arr, int size)
    {
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(" {0,3} ", arr[i, j]);
            }
            Console.WriteLine();
        }
    }
}
