using System;

class MaximalSum
{
    static void Main()
    {
        Console.Write("N: ");
        int rowsCount = int.Parse(Console.ReadLine());

        Console.Write("M: ");
        int colsCount = int.Parse(Console.ReadLine());

        double[,] matrix = new double[rowsCount, colsCount];

        // по задание К = 3, [3 x 3]
        Console.Write("Enter K - square size |K x K|: ");
        int size = int.Parse(Console.ReadLine());

        SetMatrix(matrix);
        PrintMatrix(matrix);
        FindMaxSum(matrix, size);
    }

    static void FindMaxSum(double[,] matrix, int size)
    {
        double curSum = 0;
        double maxSum = double.MinValue;
        double[,] resMatrix = new double[size, size];

        int rows = matrix.GetLength(0) - resMatrix.GetLength(0);
        int cols = matrix.GetLength(1) - resMatrix.GetLength(1);

        if (rows < 0 || cols < 0)
        {
            Console.WriteLine("The size of the matrix must be min {0}x{0}!", size);
            return;
        }

        for (int row = 0; row <= rows; row++)
        {
            for (int col = 0; col <= cols; col++)
            {
                for (int i = row; i < row + resMatrix.GetLength(0); i++)
                {
                    for (int j = col; j < col + resMatrix.GetLength(1); j++)
                    {
                        curSum += matrix[i, j]; 
                    }
                }

                if (curSum > maxSum)
                {
                    maxSum = curSum;
                    for (int i = row, rRow = 0; i < row + resMatrix.GetLength(0); i++, rRow++)
                    {
                        for (int j = col, rCol = 0; j < col + resMatrix.GetLength(1); j++, rCol++)
                        {
                            resMatrix[rRow, rCol] = matrix[i, j];
                        }
                    }
                }
                curSum = 0;
            }
        }

        Console.WriteLine("Maximal sum: {0}", maxSum);
        PrintMatrix(resMatrix);
    }

    static void SetMatrix(double[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("[{0},{1}] = ", row, col);
                matrix[row, col] = double.Parse(Console.ReadLine());
            }
        }
    }

    static void PrintMatrix(double[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0, -4} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

