using System;

class Program
{
    static void Main()
    {
        /* READ VALLEY */
        int[] valley = ReadValley();

        /* READ PATTERNS */
        int[][] patterns = ReadPattern();

        /* CALCULATE AND PRINT THE RESULT */
        Console.WriteLine(HelpDwarfs(valley, patterns));
    }

    static int[] ReadValley()
    {
        char[] delimiters = { ' ', ',' };
        int[] valley = Array.ConvertAll<string, int>(Console.ReadLine().Split(delimiters,
                StringSplitOptions.RemoveEmptyEntries), int.Parse);
        return valley;
    }

    static int[][] ReadPattern()
    {
        char[] delimiters = { ' ', ',' };

        ushort m = ushort.Parse(Console.ReadLine());
        int[][] patterns = new int[m][];

        for (int i = 0; i < m; i++)
        {
            patterns[i] = Array.ConvertAll<string, int>(Console.ReadLine().Split(delimiters,
                StringSplitOptions.RemoveEmptyEntries), int.Parse);
        }

        return patterns;
    }

    static long HelpDwarfs(int[] valley, int[][] patterns)
    {
        long result = 0;
        long curResult;
        int valleyIndex;

        for (int i = 0; i < patterns.Length; i++)
        {
            bool[] isVisited = new bool[valley.Length];
            curResult = 0;
            valleyIndex = 0;

            for (int j = 0; j < patterns[i].Length; )
            {
                curResult += valley[valleyIndex];
                isVisited[valleyIndex] = true;
                valleyIndex += patterns[i][j];
                j++;

                if (valleyIndex < 0 || valleyIndex >= valley.Length || isVisited[valleyIndex])
                {
                    break;
                }

                if (j == patterns[i].Length)
                {
                    j = 0;
                }
            }

            result = i == 0 ? curResult : Math.Max(result, curResult);
        }

        return result;
    }
}