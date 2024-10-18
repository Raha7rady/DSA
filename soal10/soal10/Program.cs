using System;

class Program
{
    static void Main()
    {
        int n = 4; 
        double result = SumOfFactorials(n);
        Console.WriteLine($"Sum of the series is: {result}");
    }

    static double SumOfFactorials(int n)
    {
        if (n == 0)
            return 0;

        return 1.0 / Factorial(n) + SumOfFactorials(n - 1);
    }

    static long Factorial(int n)
    {
        if (n == 0)
            return 1;

        return n * Factorial(n - 1);
    }
}