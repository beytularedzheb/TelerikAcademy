using System;

class TestMatrixClass
{
    static void Main()
    {
        Matrix firstMatrix = new Matrix(2, 2);
        Matrix secondMatrix = new Matrix(2, 2);

        Matrix thirdMatrix = new Matrix(2, 3);
        Matrix fourthMatrix = new Matrix(3, 2);

        Matrix resultMatrix;

        // стойностите се задават от клавиатурата
        firstMatrix.SetValuesConsole();
        secondMatrix.SetValuesConsole();

        // стойностите се генерират автоматично (-10..10)
        thirdMatrix.SetValuesAutomatically();
        fourthMatrix.SetValuesAutomatically();

        // Грешка!
        Console.WriteLine(new String('-', 80));
        Matrix testMatrix = new Matrix(0, -1);

        /**************************СЪБИРАНЕ************************************/
        // събиране: без грешка
        Console.WriteLine(new String('-', 80));
        resultMatrix = firstMatrix + firstMatrix;

        if (resultMatrix != null)
        {
            Console.WriteLine(resultMatrix.ToString());
        }

        // събиране: с грешка
        Console.WriteLine(new String('-', 80));
        resultMatrix = firstMatrix + thirdMatrix;

        if (resultMatrix != null)
        {
            Console.WriteLine(resultMatrix.ToString());
        }


        /**************************ИЗВАЖДАНЕ***********************************/
        // изваждане: без грешка
        Console.WriteLine(new String('-', 80));
        resultMatrix = firstMatrix - secondMatrix;

        if (resultMatrix != null)
        {
            Console.WriteLine(resultMatrix.ToString());
        }

        // изваждане: с грешка
        Console.WriteLine(new String('-', 80));
        resultMatrix = firstMatrix - fourthMatrix;

        if (resultMatrix != null)
        {
            Console.WriteLine(resultMatrix.ToString());
        }


        /**************************УМНОЖЕНИЕ***********************************/
        // умножение: без грешка
        Console.WriteLine(new String('-', 80));
        resultMatrix = thirdMatrix * fourthMatrix;

        if (resultMatrix != null)
        {
            Console.WriteLine(resultMatrix.ToString());
        }

        // умножение: с грешка
        Console.WriteLine(new String('-', 80));
        resultMatrix = thirdMatrix * firstMatrix;

        if (resultMatrix != null)
        {
            Console.WriteLine(resultMatrix.ToString());
        }


        /**************************ИНДЕКС************************************/
        // задаване на стойност и извеждане
        Console.WriteLine(new String('-', 80));
        firstMatrix[0, 0] = 5;
        Console.WriteLine(firstMatrix[0, 0]);
    }
}

