using System;

class SieveOfEratosthenes
{
    static void Main()
    {
        ulong length = 10000000L;
        bool[] ulongArr = new bool[length + 1];

        FindAllPrimeNumbers(ulongArr);
        PrintArray(ulongArr);
    }

    static void PrintArray(bool[] arr)
    {
        Console.WriteLine();

        for (ulong i = 2; i < (ulong)arr.Length; i++)
        {
            if (!arr[i])
            {
                Console.Write(i + " ");
            }
        }
    }

    static void FindAllPrimeNumbers(bool[] arr)
    {
        for (ulong i = 2; i < (ulong)arr.Length; i++)
        {
            if (!arr[i])
            {
                for (ulong j = i * i; j < (ulong)arr.Length; j += i)
                {
                    arr[j] = true;
                }
            }
        }
    }
}

