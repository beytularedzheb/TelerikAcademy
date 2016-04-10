using System;


class Matrix
{
    static void Main()
    {
        Console.Write("Please enter N: ");
        int N = int.Parse(Console.ReadLine());

        int[,] arr = new int[N, N];

        Console.WriteLine("\n\rExample - a)");
        ExamA(arr);

        Console.WriteLine("\n\rExample - b)");
        ExamB(arr);

        Console.WriteLine("\n\rExample - c)");
        ExamC(arr);

        Console.WriteLine("\n\rExample - d)");
        ExamD(arr);
    }

    static void PrintMatrix(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write("{0, -4}", arr[i, j]);
            }
            Console.WriteLine();
        }
    }

    static void ExamA(int[,] arr)
    {
        int counter = 1;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[j, i] = counter;
                counter++;
            }
        }

        PrintMatrix(arr);
    }

    static void ExamB(int[,] arr)
    {
        int row = 0;
        int col = 0;
        bool direction = true; 

        for (int i = 1; i <= Math.Pow(arr.GetLength(0), 2); i++)
        {
            arr[row, col] = i;

            if (direction)
            {
                row++;
                if (row == arr.GetLength(0))
                {
                    row--;
                    col++;
                    direction = false;
                }
            }
            else
            {
                row--;                
                if (row == -1)
                {
                    row++;
                    col++;
                    direction = true;
                }
            } 
        }

        PrintMatrix(arr);
    }

    static void ExamC(int[,] arr)
    {
        int counter = 1;
        int curLen = arr.GetLength(0) - 1;

        /* попълване на:
         * 7
         * 4  8
         * 2  5  9
         * 1  3  6  10
         */

        while (curLen >= 0)
        {
            for (int i = curLen; i < arr.GetLength(0); i++)
            {
                arr[i, i - curLen] = counter;
                counter++;
            }

            curLen--;
        }

        /* попълване на:
         *  11  14  16
         *      12  15
         *          13
         */

        curLen = 1;

        while (curLen <= arr.GetLength(0) - 1)
        {
            for (int i = curLen; i < arr.GetLength(0); i++)
            {
                arr[i - curLen, i] = counter;
                counter++;
            }

            curLen++;
        }


        PrintMatrix(arr);
    }

    static void ExamD(int[,] arr)
    {
        int row = -1; // определя реда
        int col = 0; // определя колоната

        byte direction = 1; // 0 - right; 1 - down; 2 - left; 3 - up
        int level = 0; // N - level определя максимум колко стъпки могат да се "извървят" в дадена посока
        int counter = 1; // брои изминати стъпки
        int n = arr.GetLength(0);

        for (int i = 1; i <= Math.Pow(n, 2); i++, counter++)
        {
            if (direction == 0) // right
            {
                col++;
                arr[row, col] = i;
                if (counter == n - level)
                {
                    counter = 0;
                    direction = 3;
                }
            }
            else if (direction == 1) // down
            {
                row++;
                arr[row, col] = i;
                if (counter == n - level)
                {
                    counter = 0;
                    direction = 0;
                    level++;
                }  
            }
            else if (direction == 2) // left
            {
                col--;
                arr[row, col] = i;
                if (counter == n - level)
                {
                    counter = 0;
                    direction = 1;
                }
            }
            else if (direction == 3) // up
            {
                row--;
                arr[row, col] = i;
                if (counter == n - level)
                {
                    counter = 0;
                    direction = 2;
                    level++;
                } 
            }
        }

        PrintMatrix(arr);
    }
}

