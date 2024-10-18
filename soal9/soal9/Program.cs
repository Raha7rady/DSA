using System;

class Program
{
    static void Main()
    {
        int n = 5; 
        long result = SumOfFactorials(n);
        Console.WriteLine($"Sum of the series is: {result}");
    }

    static long SumOfFactorials(int n)
    {
        if (n == 0)
            return 0;

        return Factorial(n) + SumOfFactorials(n - 1);
    }

    static long Factorial(int n)
    {
        if (n == 0)
            return 1;

        return n * Factorial(n - 1);
    }
}