using System;

class MaxSequenceOfEqualElements
{
    static void Main()
    {
        uint arrLength;

        Console.WriteLine("Please enter the size of the array: ");
        arrLength = uint.Parse(Console.ReadLine());

        int[] intArr = new int[arrLength];

        SetArraysElementsValue(intArr);
        int max = FindMaxSequenceOfEqualElements(intArr);

        if (max > 0)
        {
            FindAllSolutions(intArr, max);
        }
    }

    static void SetArraysElementsValue(int[] arr)
    {
        for (uint i = 0; i < arr.Length; i++)
        {
            Console.Write("[{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
    }

    // функция за намиране дължината на максималната редица
    // с равни елементи
    static int FindMaxSequenceOfEqualElements(int[] arr)
    {
        int maxSequenceLength = 0;
        int currentSeqLength = 0;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] == arr[i + 1])
            {
                currentSeqLength++;
                if (maxSequenceLength < currentSeqLength)
                {
                    maxSequenceLength = currentSeqLength;
                }
            }
            else
            {
                currentSeqLength = 0;
            }
        }

        return maxSequenceLength;
    }

    // функция за извеждане на всички редици с дължина, 
    // равна на максималната намерена дължина на
    // редицата с равни елементи
    static void FindAllSolutions(int[] arr, int max)
    {
        int maxSequenceLength = 0;
        int currentSeqLength = 0;
        int lastIndexOfSeq = 0;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] == arr[i + 1])
            {
                currentSeqLength++;

                if (maxSequenceLength <= currentSeqLength)
                {
                    maxSequenceLength = currentSeqLength;
                    lastIndexOfSeq = i + 1;

                    if (maxSequenceLength == max)
                    {
                        for (int j = lastIndexOfSeq; j >= lastIndexOfSeq - max; j--)
                        {
                            Console.Write("{0} ", arr[j]);
                        }
                        Console.WriteLine();
                    }
                }
            }
            else
            {
                currentSeqLength = 0;
            }
        }
    }
}

