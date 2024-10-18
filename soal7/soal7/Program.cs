
using System;

class Program
{
    static void Main()
    {
        int a = 48;
        int b = 18;
        int result = GCD(a, b);
        Console.WriteLine($"GCD of {a} and {b} is {result}");
    }

    static int GCD(int a, int b)
    {
        if (b == 0)
            return a;

        return GCD(b, a % b);
    }
}