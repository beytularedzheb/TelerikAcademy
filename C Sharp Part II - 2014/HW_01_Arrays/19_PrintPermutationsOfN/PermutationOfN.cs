using System;

class PermutationOfN
{
    static void Main()
    {
        Console.Write("Please enter N: ");
        int[] intArr = new int[int.Parse(Console.ReadLine())];

        bool[] isUsed = new bool[intArr.Length];
        Permutation(intArr, isUsed, 0);
    }

    static void Print(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
            Console.Write(arr[i] + 1 + " ");
        Console.WriteLine();
    }

    static void Permutation(int[] arr, bool[] isUsed, int i)
    {
        if (i == arr.Length)
        {
            Print(arr);
            return;
        }

        for (int j = 0; j < arr.Length; j++)
        {
            if (isUsed[j]) continue;

            arr[i] = j;

            isUsed[j] = true;
            Permutation(arr, isUsed, i + 1);
            isUsed[j] = false;
        }
    }
}

