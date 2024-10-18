using System;

class Program
{
    static void Main()
    {
        int a = 5;
        int b = -9;
        int result = Multiply(a, b);
        Console.WriteLine($"{a} * {b} = {result}");
    }

    static int Multiply(int a, int b)
    {
        if (b == 0)
            return 0;

        if (b < 0)
            return -Multiply(a, -b);

        return a + Multiply(a, b - 1);
    }
}