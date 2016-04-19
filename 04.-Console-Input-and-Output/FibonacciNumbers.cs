using System;

class FibonacciNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long a = 0;
        long b = 1;
        long c = 0;

        if (n == 1)
        {
            Console.WriteLine(0);
            return;
        }
        Console.Write("{0}, {1}", a, b);

        for (int i = 2; i < n; i++)
        {
            c = a + b;
            a = b;
            b = c;

            Console.Write(", {0}", c);
        }
        Console.WriteLine();
    }
}
