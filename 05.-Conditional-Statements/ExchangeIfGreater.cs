using System;

class ExchangeIfGreater
{
    static void Main()
    {
        double nA = double.Parse(Console.ReadLine());
        double nB = double.Parse(Console.ReadLine());

        if (nA > nB)
        {
            Console.WriteLine("{0} {1}", nB, nA);
        }
        else
        {
            Console.WriteLine("{0} {1}", nA, nB);
        }
    }
}
