using System;

class Program
{
    static void Main()
    {
        int n = 4;
        TruthTable(n, "");

    }

    static void TruthTable(int n, string s)
    {
        if (s.Length == n)
        {

            Console.WriteLine(s);
            return;
        }

        TruthTable(n, s + 0);
        TruthTable(n, s + 1);
        
    }
}