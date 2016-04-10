using System;
using System.Collections.Generic;

class LargestArea
{
    struct coord
    {
        public int row;
        public int col;
    }

    static void Main()
    {
        int[,] matrix = 
        {
            {1, 3, 2, 2, 2, 4}, 
            {3, 3, 3, 2, 4, 4}, 
            {4, 3, 1, 2, 3, 3}, 
            {4, 3, 1, 3, 3, 1},
            {4, 3, 3, 3, 1, 1},
        };

        int max = int.MinValue;
        int? maxItem = null;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int curResult = DepthFirstSearch(matrix, i, j);
                if (max < curResult)
                {
                    max = curResult;
                    maxItem = matrix[i, j];
                }
            }
        }
        Console.WriteLine("Item [{0}] -> {1}", maxItem, max);
    }

    static int DepthFirstSearch(int[,] matrix, int curRow, int curCol)
    {
        #region declarations
        int result = 0;
        int goal = matrix[curRow, curCol];

        coord start = new coord();
        start.row = curRow;
        start.col = curCol;

        List<coord> open = new List<coord>();
        open.Add(start);

        List<coord> closed = new List<coord>();
        #endregion

        while (open.Count > 0)
        {
            result++;

            // X е първият елемент на OPEN, т.е open[0].
            // намираме съседите на X, които GOAL, т.к 
            // другите не ни интересуват
            List<coord> neighborsList =
                GenerateNeighbors(matrix, open[0], open, closed, goal);

            // записваме Х в CLOSED, т.е казваме, че Х вече
            // е разгледан
            closed.Add(open[0]);

            // изтриваме Х от OPEN
            open.RemoveAt(0);

            // изтриваме тези съседи на Х, които вече са в
            // OPEN или CLOSED
            RemoveNeighbor(neighborsList, open, closed);

            // записваме отляво на OPEN "оцелелите" съседи
            for (int i = 0; i < neighborsList.Count; i++)
            {
                open.Add(neighborsList[i]);
            }

            neighborsList.Clear();
        }

        return result;
    }

    static List<coord> GenerateNeighbors
    (int[,] matrix, coord x, List<coord> open, List<coord> closed, int goal)
    {
        List<coord> neighborsList = new List<coord>();

        coord neighbor = new coord();

        // съседът "отдолу"
        neighbor.row = x.row + 1;
        neighbor.col = x.col;
        if (x.row < matrix.GetLength(0) - 1 && matrix[neighbor.row, neighbor.col] == goal)
        {
            neighborsList.Add(neighbor);
        }

        // съседът "отгоре"
        neighbor.row = x.row - 1;
        neighbor.col = x.col;
        if (x.row > 0 && matrix[neighbor.row, neighbor.col] == goal)
        {
            neighborsList.Add(neighbor);
        }

        // съседът "отдясно"
        neighbor.row = x.row;
        neighbor.col = x.col + 1;
        if (x.col < matrix.GetLength(1) - 1 && matrix[neighbor.row, neighbor.col] == goal)
        {
            neighborsList.Add(neighbor);
        }

        // съседът "отляво"
        neighbor.row = x.row;
        neighbor.col = x.col - 1;
        if (x.col > 0 && matrix[neighbor.row, neighbor.col] == goal)
        {
            neighborsList.Add(neighbor);
        }

        return neighborsList;
    }

    static void RemoveNeighbor(List<coord> neighbors, List<coord> open, List<coord> closed)
    {
        for (int i = 0; i < open.Count; i++)
        {
            neighbors.Remove(open[i]);
        }

        for (int i = 0; i < closed.Count; i++)
        {
            neighbors.Remove(closed[i]);
        }
    }
}

