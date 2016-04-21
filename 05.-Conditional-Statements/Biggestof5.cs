using System;

class Biggestof5
{
    static void Main()
    {
        double nfirst = double.Parse(Console.ReadLine());
        double nsecond = double.Parse(Console.ReadLine());
        double nthird = double.Parse(Console.ReadLine());
        double nfourth = double.Parse(Console.ReadLine());
        double nfifth = double.Parse(Console.ReadLine());

        Console.WriteLine(Math.Max(Math.Max(Math.Max(Math.Max(nfirst, nsecond), nthird), nfourth), nfifth));
    }
}
