using System;
using System.Collections.Generic;
using System.Text;

class Polinomial
{
    private List<double> coefficients;
    private int degree;

    public Polinomial()
    {
        degree = -1;
        coefficients = new List<double>();
    }

    public void AddCoefficient(double c)
    {
        coefficients.Add(c);
    }

    public double this[int index]
    {
        get
        {
            if (IsInBounds(index))
            {
                return coefficients[index];
            }
            throw new IndexOutOfRangeException();
        }
        set
        {
            if (IsInBounds(index))
            {
                coefficients[index] = value;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
    }

    private bool IsInBounds(int index)
    {
        if (index > -1 && index < coefficients.Count)
        {
            return true;
        }
        return false;
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < coefficients.Count; i++)
        {
            result.Append(coefficients[i]);
            result.Append(" ");
        }
        return result.ToString();
    }

    public static Polinomial operator +(Polinomial a, Polinomial b)
    {
        Polinomial result = new Polinomial();
        double curAddRes = 0d;
        for (int i = 0; i < Math.Max(a.coefficients.Count, b.coefficients.Count); i++)
        {
            if (i < a.coefficients.Count)
            {
                curAddRes += a[i];
            }

            if (i < b.coefficients.Count)
            {
                curAddRes += b[i];
            }

            result.AddCoefficient(curAddRes);
            curAddRes = 0d;
        }

        return result;
    }

    public static Polinomial operator *(Polinomial a, Polinomial b)
    {
        Polinomial result = new Polinomial();
        for (int i = 0; i < a.coefficients.Count + b.coefficients.Count -1; i++)
        {
            result.AddCoefficient(0d);
        }

        for (int i = 0; i < a.coefficients.Count; i++)
        {
            for (int j = 0; j < b.coefficients.Count; j++)
            {
                result[i+ j] += (a[i] * b[j]);
            }
        }
        return result;
    }

    public static Polinomial operator -(Polinomial a, Polinomial b)
    {
        Polinomial result = new Polinomial();
        double curAddRes = 0d;
        for (int i = 0; i < Math.Max(a.coefficients.Count, b.coefficients.Count); i++)
        {
            if (i < a.coefficients.Count)
            {
                curAddRes += a[i];
            }

            if (i < b.coefficients.Count)
            {
                curAddRes -= b[i];
            }

            result.AddCoefficient(curAddRes);
            curAddRes = 0d;
        }

        return result;
    }

    public void ReadPolinomial()
    {
        Console.Write("Please enter the polinomial degree: ");
        if (!int.TryParse(Console.ReadLine(), out degree))
        {
            Console.WriteLine("Invalid input data!");
            return;
        }
        double input = 0d;
        for (uint i = 0; i <= degree; i++)
        {
            Console.Write("Coeff. {0} = ", i);
            if (!double.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Invalid input data!");
                return;
            }
            AddCoefficient(input);
        }
    }
}

