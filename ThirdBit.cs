using System;

class ThirdBit
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());

        int b = a >> 3;
        int result = b & 1;

        Console.WriteLine(result);
    }
}