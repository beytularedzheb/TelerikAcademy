using System;

class FirstElementBiggerThanNeighbors
{
    static void Main()
    {
        // т.к използвам функцията от 5 задача, за да се получи резултат
        // различен от -1, то елементът от зададената позиция трябва да е
        // по-голям от 2 си съседа.
        int[] intArr1 = 
        {
            -1, 0, 1, 1, 13, 42, 77,
            66, 53, 7, 6, 5, 12, -50
        };

        int[] intArr2 = 
        {
            1, 1, 1
        };

        // първи случай - има два съседа
        Console.WriteLine(GetFirstItemIndexBiggerThanNeighbors(intArr1)); // 77
        // втори случай - няма такъв елемент
        Console.WriteLine(GetFirstItemIndexBiggerThanNeighbors(intArr2)); 
    }

    static int GetFirstItemIndexBiggerThanNeighbors(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (CheckBiggerThanNeighbors(arr, i))
            {
                return i;
            }
        }
        return -1;
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
        // - не е по-голям или няма съседи (има само 1 елемент),
        // - или не е в границите на масива
        return false;
    }
}

