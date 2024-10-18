using System;

class Program
{
    static int function(string s, int x)
    {
        s = s.Replace(" ", "");

        if (s == "x")
        {
            return x;
        }

        bool isNumber = true;
        foreach (char c in s)
        {
            if (!char.IsDigit(c))
            {
                isNumber = false;
                break;
            }
        }

        if (isNumber)
        {
            return int.Parse(s);
        }

        int i = s.Length - 1;

        while (i >= 0)
        {
            if (s[i] == '+' || s[i] == '-')
            {
                if (s[i] == '+')
                {
                    return function(s.Substring(0, i), x) + function(s.Substring(i + 1), x);
                }
                else
                {
                    return function(s.Substring(0, i), x) - function(s.Substring(i + 1), x);
                }
            }
            i--;
        }

        i = s.Length - 1;

        while (i >= 0)
        {
            if (s[i] == '*' || s[i] == '/')
            {
                if (s[i] == '*')
                {
                    return function(s.Substring(0, i), x) * function(s.Substring(i + 1), x);
                }
                else
                {
                    return function(s.Substring(0, i), x) / function(s.Substring(i + 1), x);
                }
            }
            i--;
        }

        return 0;
    }

    static void Main()
    {
        int x = 5; 
        Console.WriteLine(function("x*x+x+x-x*x", x));
    }
}