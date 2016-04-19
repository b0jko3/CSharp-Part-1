using System;

class SumofNNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double r = 0;

        for (int i = 1; i <= n; i++)
        {
            r += double.Parse(Console.ReadLine());
        }
        Console.WriteLine("{0}", r);
    }
}
