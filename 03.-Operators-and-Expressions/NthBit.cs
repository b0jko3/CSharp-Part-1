using System;

class NthBit
{
    static void Main()
    {
        long p = long.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        long b = p >> n;
        long result = b & 1;

        Console.WriteLine(result);
    }
}
