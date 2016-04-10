using System;

class SequenceOfFibonacci
{
    static void Main(string[] args)
    {
        ulong beforeLastResult = 0;
        ulong lastResult = 0;

        for (int i = 0; i < 100; i++)
        {
            if (i == 0)
            {
                Console.WriteLine("[{0}] {1}", i + 1, i);      
            }
            else if (i == 1)
            {
                Console.WriteLine("[{0}] {1}", i + 1, i);
                lastResult = i;
            }
            else
            {
                ulong result = beforeLastResult + lastResult;
                Console.WriteLine("[{0}] {1}", i + 1, result);
                beforeLastResult = lastResult;
                lastResult = result;
            }
        } 
    }
}
