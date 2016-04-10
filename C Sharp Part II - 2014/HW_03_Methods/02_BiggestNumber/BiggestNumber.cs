using System;

class BiggestNumber
{
    static void Main()
    {
        int[] numbers = new int[3];
        SetNumbers(numbers);

        int max = numbers[0];
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            max = GetMax(max, numbers[i + 1]);
        }

        Console.WriteLine("The biggest number is: {0}.", max);
    }

    static int GetMax(int firstNum, int secondNum)
    {
        if (firstNum > secondNum)
        {
            return firstNum;
        }
        return secondNum;
    }

    static void SetNumbers(int[] numArr)
    {
        for (int i = 0; i < numArr.Length; i++)
        {
            Console.Write("[{0}] = ", i);
            numArr[i] = int.Parse(Console.ReadLine());
        }
    }
}

