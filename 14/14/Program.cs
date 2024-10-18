using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of disks: ");
        int n = int.Parse(Console.ReadLine());

        Hanoi(n, 'S', 'A', 'D');
    }

    static void Hanoi(int n, char from, char aux, char to)
    {
        if (n == 1)
        {
            Console.WriteLine($"{from} -> {aux}");
            Console.WriteLine($"{aux} -> {to}");
            return;
        }

        Hanoi(n - 1, from, to, aux);

        Console.WriteLine($"{from} -> {aux}");

        Hanoi(n - 1, aux, from, to);

        Console.WriteLine($"{aux} -> {to}");

        Hanoi(n - 1, from, aux, to);
    }
}