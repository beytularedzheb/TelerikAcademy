using System;

class CheckNumIfBiggestThanNeighbors
{
    static void Main()
    {
        int[] intArr = 
        {
            1, 0, 5, 1, 13, 42, 77,
            66, 53, 7, 6, 5, 12, -50
        };

        // тестове
        int position = 0; // 1 - няма ляв съсед
        Console.WriteLine(CheckBiggerThanNeighbors(intArr, position));

        position = 6; // 77 - по-голям от съседите си
        Console.WriteLine(CheckBiggerThanNeighbors(intArr, position));

        position = 8; // 53 - не е по-голям
        Console.WriteLine(CheckBiggerThanNeighbors(intArr, position));

        position = 13; // -50 - няма десен съсед
        Console.WriteLine(CheckBiggerThanNeighbors(intArr, position));
    }

    static bool CheckBiggerThanNeighbors(int[] arr, int pos)
    {
        if (pos == 0 && arr.Length > 1)
        {
            if (arr[pos] > arr[pos + 1])
            {
                // ако е по-голям
                return true;
            }
        }

        if (pos == arr.Length - 1 && arr.Length > 1)
        {
            if (arr[pos] > arr[pos - 1])
            {
                // ако е по-голям
                return true;
            }
        }

        if (pos > 0 && pos < arr.Length - 1)
        {
            if (arr[pos] > arr[pos - 1] && arr[pos] > arr[pos + 1])
            {
                // ако е по-голям
                return true;
            }
        }
        // - не е в границите на масива
        return false;
    }
}