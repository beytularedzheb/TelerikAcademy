using System;

class LongestSequnce
{
    static void Main()
    {
        Console.Write("N: ");
        int rowsCount = int.Parse(Console.ReadLine());

        Console.Write("M: ");
        int colsCount = int.Parse(Console.ReadLine());

        string[,] matrix = new string[rowsCount, colsCount];

        SetMatrix(matrix);
        PrintMatrix(matrix);
        Find(matrix);
    }

    static void SetMatrix(string[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("[{0},{1}] = ", row, col);
                matrix[row, col] = Console.ReadLine();
            }
        }
    }

    static void PrintMatrix(string[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static void Find(string[,] matrix)
    {
        int max = 0;
        int count = 0;
        string str = "", dir = "";

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            { 
                // вертикал
                for (int i = row; i < matrix.GetLength(0) - 1; i++)
                {                   
                    if (matrix[i, col] == matrix[i + 1, col])
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (count > max)
                {
                    max = count;
                    str = matrix[row, col];
                    dir = "Vertical";
                }
                count = 0;

                // хоризонтал
                for (int i = col; i < matrix.GetLength(1) - 1; i++)
                {
                    if (matrix[row, i] == matrix[row, i + 1])
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
                
                if (count > max)
                {
                    max = count;
                    str = matrix[row, col];
                    dir = "Horizontal";
                }
                count = 0;

                // диагонал - надясно и надолу
                for (int i = row, j = col; 
                    i < matrix.GetLength(0) - 1 && 
                    j < matrix.GetLength(1) - 1; 
                    i++, j++)
                {
                    if (matrix[i, j] == matrix[i + 1, j + 1])
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (count > max)
                {
                    max = count;
                    str = matrix[row, col];
                    dir = "Diagonal - To Right-Bottom";
                }
                count = 0;

                // диагонал - наляво и надолу
                for (int i = row, j = col;
                    i < matrix.GetLength(0) - 1 && j > 0;
                    i++, j--)
                {
                    if (matrix[i, j] == matrix[i + 1, j - 1])
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (count > max)
                {
                    max = count;
                    str = matrix[row, col];
                    dir = "Diagonal - To Left-Bottom";
                }
                count = 0;
            }
        }

        Console.WriteLine(dir);
        for (int i = 0; i <= max; i++)
        {
            Console.Write(str + " ");
        }
        Console.WriteLine();
    }
}