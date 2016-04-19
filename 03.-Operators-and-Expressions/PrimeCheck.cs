using System;

class PrimeCheck
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        bool isPrime = true;
        if ((number <= 0) || (number == 1))
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; Math.Pow(i, 2) <= number; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }
        Console.WriteLine(isPrime ? "true" : "false");
    }
}
