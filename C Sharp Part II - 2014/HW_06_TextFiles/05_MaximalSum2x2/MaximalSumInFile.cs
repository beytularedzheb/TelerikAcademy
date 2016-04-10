using System;
using System.IO;

public class MaximalSumInFile
{
    private const string InputFilePath = @"../../input.txt";
    private const string OutputFilePath = @"../../output.txt";
    private const int MaxSumMatrixSize = 2;
    private static double[,] arr;

    public static void Main()
    {
        try
        {
            int size = 0;
            ReadInputFile(InputFilePath, ref size, ref arr);
            SaveToFile(OutputFilePath, FindMaxSum(arr, MaxSumMatrixSize));
            Console.WriteLine("OK");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static void SaveToFile(string outFilePath, double result)
    {
        using (var sw = new StreamWriter(outFilePath))
        {
            sw.WriteLine(result);
        }
    }

    private static void ReadInputFile(string inFilePath, ref int size, ref double[,] arr)
    {
        if (File.Exists(inFilePath))
        {
            using (StreamReader inFile = new StreamReader(inFilePath))
            {
                string line = inFile.ReadLine();
                if (line != null)
                {
                    int.TryParse(line, out size);
                }

                if (size >= 2 && size == File.ReadAllLines(inFilePath).Length - 1)
                {
                    arr = new double[size, size];
                    int i = 0, j = 0;

                    while ((line = inFile.ReadLine()) != null)
                    {
                        char[] delimiter = { ' ', '\t' };
                        string[] lineItems = line.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
                        if (lineItems.Length == size)
                        {
                            while (j < lineItems.Length - 1)
                            {
                                if (!double.TryParse(lineItems[j], out arr[i, j]))
                                {
                                    throw new FormatException();
                                }

                                j++;
                            }

                            j = 0;
                            i++;
                        }
                        else
                        {
                            Console.WriteLine("Incorrectly written input file!");
                            return;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Incorrectly written input file!");
                    return;
                }
            }
        }
        else
        {
            throw new FileNotFoundException("Unable to find " + inFilePath);
        }
    }

    private static double FindMaxSum(double[,] matrix, int size)
    {
        double curSum = 0;
        double maxSum = double.MinValue;
        double[,] resMatrix = new double[size, size];

        int rows = matrix.GetLength(0) - resMatrix.GetLength(0);
        int cols = matrix.GetLength(1) - resMatrix.GetLength(1);

        if (rows < 0 || cols < 0)
        {
            throw new ArgumentException("Incorrect matrix size!");
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
                }

                curSum = 0;
            }
        }

        return maxSum;
    }
}