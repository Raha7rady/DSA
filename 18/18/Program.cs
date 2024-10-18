using System;

class Program
{
    static bool IsDuplicate(string s)
    {
        int n = s.Length;

        for (int i = 1; i <= n / 2; i++)
        {
            if (n % i == 0)
            {
                string sub = s.Substring(0, i);
                string repeated = "";

                for (int j = 0; j < n / i; j++)
                {
                    repeated += sub;
                }

                if (repeated == s) return true;
            }
        }
        return false;
    }

    static void Main()
    {
        string s = "abab"; 
        if (IsDuplicate(s))
        {
            Console.WriteLine("The string is a Duplicate.");
        }
        else
        {
            Console.WriteLine("The string is not a Duplicate.");
        }
    }
}