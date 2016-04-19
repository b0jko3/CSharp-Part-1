using System;

class MoonGravity
{
    static void Main()
    {
        float weight = float.Parse(Console.ReadLine());
        weight *= 0.17f;
        Console.WriteLine("{0:0.000}", weight);
    }
}