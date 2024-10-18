using System;

class Program
{
    static int Ack(int m, int n)
    {
        if (n < 0 || m < 0) return 0;
        else if (m == 0) return n + 1;
        else if (n == 0) return Ack(m - 1, 1);
        else return Ack(m - 1, Ack(m, n - 1));
    }

    static void Main()
    {
        int m = 3; 
        int n = 2; 

        Console.WriteLine($"Ack({m}, {n}) = {Ack(m, n)}");
    }
}