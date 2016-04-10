using System;

class Program
{
    static void Main()
    {
        int[][] arr = ReadInput();
        int max = -1;
        
        for (int i = 0; i < arr[0].Length; i++)
        {
            max = Math.Max(SpecialValue(arr, i), max);
        }

        Console.WriteLine(max);
    }

    static int[][] ReadInput()
    {
        char[] del = { ' ', ',' };

        int rows = int.Parse(Console.ReadLine());
        int[][] arr = new int[rows][];

        for (int i = 0; i < rows; i++)
        {
            arr[i] = Array.ConvertAll<string, int>(Console.ReadLine().Split(del, 
                StringSplitOptions.RemoveEmptyEntries), int.Parse);
        }

        return arr;
    }

    static int SpecialValue(int[][] arr, int firstRowsStartColumn)
    {
        int i, j, max = 0;
        int path = 1, buf;

        bool[][] boolArr = new bool[arr.Length][];
        for (j = 0; j < boolArr.Length; j++)
        {
            boolArr[j] = new bool[arr[j].Length];
        }

        for (j = firstRowsStartColumn, i = 0; j < arr[i].Length; j++)
        {
            if (!boolArr[i][j])
            {
                if (arr[i][j] < 0)
                {
                    max = Math.Max(Math.Abs((int)arr[i][j]) + path, max);
                    path = 1;
                    boolArr[i][j] = true; // visited
                    i = 0;
                    j = -1;
                }
                else
                {
                    buf = j;
                    j = (int)arr[i][buf] - 1;
                    boolArr[i][buf] = true; // visited
                    i = i < arr.Length - 1 ? i + 1 : 0;
                    path++;
                }
            }
            else if (i == 0)
            {
                break;
            }
        }

        return max;
    }
}