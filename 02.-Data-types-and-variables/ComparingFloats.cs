using System;

class ComparingFloats
{
    static void Main()
    {
        var first = decimal.Parse(Console.ReadLine());
        var second = decimal.Parse(Console.ReadLine());

        if (((second - first) == 0.000001m) || (first - second) == 0.000001m)
        {
            Console.WriteLine("false");
        }
        else if ((first * -1) == (second) || (first == (second * -1)) || (float)first == (float)second)
        {
            Console.WriteLine("true", true, (first - second) * -1);
        }
        else
        {
            Console.WriteLine("false", false, second - first);
        }
    }
}
