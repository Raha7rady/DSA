using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Binary representation: ");
        PrintBinary(number);
        Console.WriteLine(); 
    }

    static void PrintBinary(int num)
    {
        if (num == 0)
        {
            return;
        }

        PrintBinary(num / 2);

        Console.Write(num % 2);
    }
}