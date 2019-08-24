using System;
using System.Diagnostics;

namespace fifty_line_code
{
    class Program
{
    private static int Fib(int n, int current = 1, int next = 1)
    {
        while (true)
        {
            if (n < 2)
                return current;
            else
            {
                var current1 = current;
                n = --n;
                current = next;
                next = current1 + next;
            }
        }
    }

    private static void Main()
    {
        Console.WriteLine(Fib(40));
    }
}
}
