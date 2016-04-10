using System;

class ExamplePolinomials
{
    static void Main()
    {
        // полиномите се въвеждат и извеждат на екрана така, както е на презентацията
        // Пример: 1*x^2 + 0*x + 5. трябва да се въведе по следния начин: 5 0 1
        // резултатър също се извежда по този начин
        Polinomial a = new Polinomial();
        a.ReadPolinomial();

        Polinomial b = new Polinomial();
        b.ReadPolinomial();

        Console.WriteLine("Multiplication");
        Console.WriteLine((a * b).ToString());

        Console.WriteLine("Substraction");
        Console.WriteLine((a - b).ToString());

        Console.WriteLine("Sum");
        Console.WriteLine((a + b).ToString());
    }
}

