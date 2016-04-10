using System;

class FrequencyOfOccurrence
{
    static void Main()
    {
        int[] intArr = 
        {
            1, 2, 0, -1, 1, 5,
            6, 3, 3, 2, 9, 15,
            16, 0, 3
        };
        int searchNum = -2;
        int result = GetFrequencyOfOccurrence(intArr, searchNum);
        Console.WriteLine("{0} -> {1}", searchNum, result);
    }

    static int GetFrequencyOfOccurrence(int[] arr, int num)
    {
        int counter = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (num == arr[i])
            {
                counter++;
            }
        }
        return counter;
    }
}

