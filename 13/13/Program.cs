using System;

class Program
{
    static void Main()
    {
        int n = 2;
        hanoi(n, 'S', 'D', 'A');
    }

    static void hanoi(int n, char source, char destination, char auxiliary)
    {
        if (n == 1)
        {
            Console.WriteLine($"{source} -> {destination}");
            return;
        }

        hanoi(n - 1, source, auxiliary, destination);

        Console.WriteLine($"{source} -> {destination}");

        hanoi(n - 1, auxiliary, destination, source);
    }
}