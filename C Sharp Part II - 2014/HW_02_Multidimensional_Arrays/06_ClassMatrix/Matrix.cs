using System;

class Matrix
{
    private int rowsCount;
    private int colsCount;
    public int[,] matrix;

    public Matrix(int rows, int cols)
    {
        if (rows > 0 && cols > 0)
        {
            rowsCount = rows;
            colsCount = cols;
            matrix = new int[rows, cols];
        }
        else
        {
            Console.WriteLine("The count of the rows/columns can't be <= 0!");
        }
    }

    public void SetValuesConsole()
    {
        for (int row = 0; row < rowsCount; row++)
        {
            for (int col = 0; col < colsCount; col++)
            {
                Console.Write("[{0}, {1}] = ", row, col);
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine();
    }

    public void SetValuesAutomatically()
    {
        Random randGen = new Random();

        for (int row = 0; row < rowsCount; row++)
        {
            for (int col = 0; col < colsCount; col++)
            {
                matrix[row, col] = randGen.Next(-10, 10);
            }
        }
    }

    public override string ToString()
    {
        string result = "";

        for (int row = 0; row < rowsCount; row++)
        {
            for (int col = 0; col < colsCount; col++)
            {
                result += matrix[row, col] + " ";
            }
            result += "\n\r";
        }

        return result;   
    }

    public int? this[int row, int col]
    {
        get
        {
            if (matrix != null)
            {
                return matrix[row, col];
            }
            else
            {
                return null;
            }
        }

        set
        {
            if (matrix != null)
            {
                matrix[row, col] = (int)value;
            }
        }
    }

    public static Matrix operator +(Matrix fMat, Matrix sMat)
    {
        if (fMat.rowsCount == sMat.rowsCount &&
            fMat.colsCount == sMat.colsCount)
        {
            Matrix result = new Matrix(fMat.rowsCount, fMat.colsCount);

            for (int row = 0; row < result.rowsCount; row++)
            {
                for (int col = 0; col < result.colsCount; col++)
                {
                    result[row, col] = fMat[row, col] + sMat[row, col];
                }
            }

            return result;
        }
        else
        {
            Console.WriteLine("(+) Both matrices aren't of the same size!");
            return null;
        }   
    }

    public static Matrix operator -(Matrix fMat, Matrix sMat)
    {
        if (fMat.rowsCount == sMat.rowsCount &&
            fMat.colsCount == sMat.colsCount)
        {
            Matrix result = new Matrix(fMat.rowsCount, fMat.colsCount);

            for (int row = 0; row < result.rowsCount; row++)
            {
                for (int col = 0; col < result.colsCount; col++)
                {
                    result[row, col] = fMat[row, col] - sMat[row, col];
                }
            }

            return result;
        }
        else
        {
            Console.WriteLine("(-) Both matrices aren't of the same size!");
            return null;
        }
    }

    public static Matrix operator *(Matrix fMat, Matrix sMat)
    {
        if (fMat.colsCount == sMat.rowsCount)
        {
            Matrix result = new Matrix(fMat.rowsCount, sMat.colsCount);

            for (int row = 0; row < fMat.rowsCount; row++)
            {
                for (int col = 0; col < sMat.colsCount; col++)
                {
                    for (int i = 0; i < fMat.colsCount; i++)
                    {
                        result[row, col] += fMat[row, i] * sMat[i, col];
                    }
                }
            }

            return result;
        }
        else
        {
            Console.WriteLine("(*) Both matrices can't be multiplied together because the number of " + 
                "columns in first matrix does not equal the number of rows in second matrix!");
            return null;
        }
    }
}

