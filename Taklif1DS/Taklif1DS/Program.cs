//question1
using System;

class Program
{
    public static void Main()
    {
        int a = 10;
        int b = 3;

        int result = Divide(a, b);
        Console.WriteLine($"The result of {a} / {b} is: {result}");
    }

    public static int Divide(int a, int b)
    {

        if (a < b)
        {
            return 0;
        }

        return 1 + Divide(a - b, b);
    }
}