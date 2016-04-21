using System;

class MultiplicationSign
{
    static void Main()
    {
        double nfirst = double.Parse(Console.ReadLine());
        double nsecond = double.Parse(Console.ReadLine());
        double nthird = double.Parse(Console.ReadLine());
        double product = nfirst * nsecond * nthird;

        if (product < 0)
        {
            Console.WriteLine("-");
        }
        else if (product == 0)
        {
            Console.WriteLine("0");
        }
        else if (product > 0)
        {
            Console.WriteLine("+");
        }
    }
}
