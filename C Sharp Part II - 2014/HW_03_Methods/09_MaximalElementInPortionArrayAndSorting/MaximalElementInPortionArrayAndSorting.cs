using System;

class MaximalElementInPortionArrayAndSorting
{
    static void Main()
    {
        int[] arr = 
        {
            1, 5, 6, -1, 1, 2
        };

        // възходящ ред
        SortArray(arr, false);
        PrintArray(arr);

        // низходящ ред
        SortArray(arr, true);
        PrintArray(arr);
    }

    static int MaxElemetInPortionArray(int[] arr, int pos)
    {
        if (!IsInArrayBounds(arr, pos))
        {
            throw new IndexOutOfRangeException();
        }

        int maximal = pos;
        for (int i = pos + 1; i < arr.Length; i++)
        {
            if (arr[maximal] < arr[i])
            {
                maximal = i;
            }
        }
        return maximal;
    }

    static bool IsInArrayBounds(int[] arr, int pos)
    {
        if (pos < 0 || pos > arr.Length - 1)
        {
            return false;
        }
        return true;
    }

    static void SortArray(int[] arr, bool InDec)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            int maxElemInd = MaxElemetInPortionArray(arr, i);
            SwapIntNumbers(ref arr[maxElemInd], ref arr[i]);
        }

        if (!InDec)
        {
            int len = arr.Length - 1;
            for (int i = 0; i < arr.Length / 2; i++, len--)
            {
                SwapIntNumbers(ref arr[i], ref arr[len]);
            }
        }
    }

    static void SwapIntNumbers(ref int firstNum, ref int secondNum)
    {
        int swap = firstNum;
        firstNum = secondNum;
        secondNum = swap;
    }

    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write("{0} ", num);
        }
        Console.WriteLine();
    }
}

